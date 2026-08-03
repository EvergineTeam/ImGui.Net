"""Point the generated variadic imports at their zero-argument entry points.

C# cannot safely call a C variadic function. On AArch64 -- Apple silicon, Windows on
ARM, and the Linux arm64 we ship -- variadic arguments use a different calling
convention from named ones, so binding a fixed managed signature to a variadic native
symbol is incorrect at the ABI level even though it links and appears to work on x64.

cimgui solves this by emitting a non-variadic companion for each variadic function,
named with a trailing zero and guarded by CIMGUI_VARGS0, "for compatibility with
languages such as C#" in its own words. The companions exist in cimgui.h and in the
compiled library, but they are absent from generator/output/definitions.json, which is
what our four generators read. So the generators cannot produce the mapping, and the
mappings currently in the checked-in output survive only because they were generated
back when the definitions did contain them -- meaning anyone who regenerates today
silently rebinds ImGui.Text and friends to the variadic symbols.

Reported upstream as cimgui/cimgui#323. When the definitions carry the companions this
script becomes a no-op and should be deleted.

Nothing here is hardcoded: the variadic set comes from the definitions, and which
companions exist comes from the submodule's own header. If upstream adds or removes
one, this follows without being edited.
"""

import json
import re
import sys
from pathlib import Path

ROOT = Path(__file__).resolve().parents[2]

# Each generator, the definitions it reads, the header that says which companions were
# emitted, and the folder it writes.
PROJECTS = [
    ("Imgui", "ImguiGen", "cimgui", "cimgui.h"),
    ("Imguizmo", "ImguizmoGen", "cimguizmo", "cimguizmo.h"),
    ("Imnodes", "ImnodesGen", "cimnodes", "cimnodes.h"),
    ("Implot", "ImplotGen", "cimplot", "cimplot.h"),
]

# Declarations to drop rather than map, because upstream emits no companion for them
# and binding to the variadic symbol would be wrong on the three ARM64 targets. Only
# functions that are already broken belong here: removing one that works is an API
# break, and that is a decision for a human, not for this script.
#
# ImGuiTextBuffer_appendf currently names an entry point that does not exist, so every
# call throws EntryPointNotFoundException. Removing it costs nothing.
DROP = {"ImGuiTextBuffer_appendf"}

DLLIMPORT_LINE = re.compile(r'^(?P<indent>[ \t]*)\[DllImport\("(?P<lib>[^"]+)"(?P<args>[^)]*)\)\]')


def variadic_symbols(gen):
    """Symbols the definitions mark as variadic."""
    path = ROOT / "Generator" / gen / "Jsons" / "definitions.json"
    definitions = json.loads(path.read_text(encoding="utf-8"))
    return {
        overload.get("ov_cimguiname") or overload.get("cimguiname")
        for overloads in definitions.values()
        for overload in overloads
        if overload.get("isvararg")
    }


def available_companions(submodule, header, symbols):
    """Which of those actually have a zero-argument companion in the C header."""
    path = ROOT / "NativeLibraries" / submodule / header
    text = path.read_text(encoding="utf-8", errors="replace")
    return {s for s in symbols if f"{s}0(" in text}


def process(folder, symbols, companions):
    mapped, dropped, unmapped = 0, 0, []

    for source in sorted((ROOT / "Generator" / "Evergine.Bindings.Imgui" / folder).glob("*.cs")):
        # Whether the file carries a byte order mark is preserved rather than assumed.
        # Reading with utf-8-sig strips one and writing with it adds one, so a file
        # without a BOM came back with a BOM and every line of it read as changed --
        # enough on its own to make the CD believe the API moved.
        raw = source.read_bytes()
        bom = raw.startswith(b"\xef\xbb\xbf")
        lines = raw.decode("utf-8-sig").splitlines(keepends=True)
        out, index, changed = [], 0, False

        while index < len(lines):
            match = DLLIMPORT_LINE.match(lines[index])
            if not match or index + 1 >= len(lines):
                out.append(lines[index])
                index += 1
                continue

            declaration = lines[index + 1]
            name = re.search(r'(\w+)\s*\(', re.sub(r'\[[^\]]*\]', " ", declaration))
            existing = re.search(r'EntryPoint\s*=\s*"([^"]+)"', match.group("args"))
            symbol = existing.group(1) if existing else (name.group(1) if name else None)
            base = symbol[:-1] if symbol and symbol.endswith("0") else symbol

            if base in DROP:
                index += 2
                changed = True
                dropped += 1
                continue

            if base in symbols:
                if base in companions:
                    if symbol != f"{base}0":
                        args = match.group("args").rstrip()
                        out.append(f'{match.group("indent")}[DllImport("{match.group("lib")}"'
                                   f'{args}, EntryPoint = "{base}0")]\n')
                        changed = True
                        mapped += 1
                    else:
                        out.append(lines[index])
                        mapped += 1
                else:
                    out.append(lines[index])
                    unmapped.append(base)
            else:
                out.append(lines[index])

            out.append(declaration)
            index += 2

        if changed:
            payload = "".join(out).encode("utf-8")
            source.write_bytes((b"\xef\xbb\xbf" + payload) if bom else payload)

    return mapped, dropped, unmapped


def main():
    total_mapped = total_dropped = 0
    risky = []

    for folder, gen, submodule, header in PROJECTS:
        symbols = variadic_symbols(gen)
        if not symbols:
            print(f"{folder}: no variadic functions.")
            continue
        companions = available_companions(submodule, header, symbols)
        mapped, dropped, unmapped = process(folder, symbols, companions)
        total_mapped += mapped
        total_dropped += dropped
        risky += unmapped
        print(f"{folder}: {len(symbols)} variadic, {len(companions)} with a companion, "
              f"{mapped} mapped, {dropped} dropped.")

    print(f"\n{total_mapped} import(s) bound to a zero-argument entry point, "
          f"{total_dropped} removed.")

    if risky:
        # Not an error: these work on x64 and removing them would break a published
        # API, which is a human's call. But the coherence check cannot see this -- the
        # variadic symbol does exist, so it passes while the ABI is still wrong on
        # ARM64. Say so on every run rather than letting it go quiet.
        print("\n::warning::still bound to a variadic symbol, which is incorrect on "
              "AArch64: " + ", ".join(sorted(set(risky))))
    return 0


if __name__ == "__main__":
    sys.exit(main())
