# Release pipeline

This file used to be the release checklist: a numbered list of things a person did by hand to
take a new cimgui into a published NuGet. Every one of those steps now runs in CI, so what is
left here is the map from the old procedure to what performs it today. That map is worth
keeping, because `binding.yml` refers back to this file and because reading it is the quickest
way to understand why the workflows are shaped the way they are.

## The manual procedure, and what replaced each step

| Was | Is |
|---|---|
| 1.1 Start one agent per platform | The `natives` job in `CD.yml`, which calls `build-native-libs.yml` and fans out over the seven platforms |
| 1.2 Update the cimgui submodule to the latest version | `binding-fetch-upstream`, driven by `upstream.bump: together` in `binding.yml` — the four submodules move as one, because they are four forks of the same imgui |
| 1.3 Build with the ImGui.NET-nativebuild scripts | `build/scripts`, invoked by the native jobs |
| 1.4 Copy `definitions.json` and `structs_and_enums.json` from one platform's output into `ImguiGen/Jsons` | `sources[].exports` in `binding.yml`, verified by `check-exports-fresh.py` |
| 1.5 Copy the native libraries into `runtimes/<rid>` | `natives-artifact-pattern: cimgui-*`, verified by `check-native-coherence.py` and `check-native-arch.py` |
| 1.6 Commit and push | `binding-tracked-cd` commits, and only when the API actually moved |
| 2. Build and run ImguiGen, commit and push | The generate step of the same workflow, for all four generators rather than one |
| 3. Pack and publish to nightly and nuget.org | The publish step, behind `publish-enabled` |

## What the automation added that no checklist could

Step 1.4 is the one worth pausing on. Copying the JSON blobs by hand was a step that failed
silently when skipped: the generators kept reading the previous version's definitions, so the
bindings were generated from one cimgui while the native libraries came from another, and
nothing anywhere reported a disagreement. Declaring them as `exports` and checking their
freshness is what makes that state impossible rather than merely unlikely.

The same is true of 1.5. Nothing verified that the file dropped into `runtimes/osx-x64` was
actually an x64 build. `check-native-arch.py` reads the Mach-O, ELF and archive headers and
compares them against the RID in the path, which caught a published `osx-x64` that was arm64.

## Two things removed from this file

A NuGet API key was written down here in plain text. It is gone from the working tree, but it
remains in this repository's history, so treat it as disclosed regardless of whether it still
works: the only thing that settles it is that the key is revoked at nuget.org. Publishing uses
the `NUGET_API_KEY` secret and never a literal.

A `cmake` invocation configuring Boost and OpenCV against `Z:\opt` was also here. It has
nothing to do with this repository — no part of cimgui or its three companions depends on
either library.
