import argparse
import os
import subprocess
import shutil
import platform

root_path = os.path.abspath(os.path.dirname(__file__))

vckpg_triplets = {
    "win-x64": "x64-windows-static",
    "win-x86": "x86-windows-static",
    "win-arm64": "arm64-windows-static",
    "linux-x64": "x64-linux",
    "linux-arm64": "arm64-linux",
    "osx-arm64": "arm64-osx",
    "osx-x64": "x64-osx",
    "browser-wasm": "wasm32-emscripten"
}

def rel_path(path):
    return os.path.join(root_path, path)

def build_path(platform):
    path = os.path.join(rel_path("build"), platform)
    os.makedirs(path, exist_ok=True)
    return path

def create_dir(path):
    os.makedirs(os.path.dirname(path), exist_ok=True)

def new_dir(path):
    if os.path.exists(path):
        shutil.rmtree(path)
    create_dir(path)

def common_cmake_args(target, buildMode, freetype = False):
    return [
        "-S", root_path,
        "-B", build_path(target),
        "-DIMGUI_WCHAR32=ON",
        "-DIMGUI_FREETYPE=" + ("ON" if freetype else "OFF"),
        f"-DCMAKE_BUILD_TYPE={buildMode}",
    ]

def inWindows():
    return os.name == "nt"

def setup_vcpkg(target):
    vcpkg_path = rel_path("vcpkg")
    subprocess.call(["git", "clone", "https://github.com/Microsoft/vcpkg.git"])
    bootstrap_vcpkg = os.path.join(vcpkg_path, "bootstrap-vcpkg.bat" if inWindows() else "bootstrap-vcpkg.sh")
    vcpkg = os.path.join(vcpkg_path, "vcpkg.exe" if inWindows() else "vcpkg")
    subprocess.call(bootstrap_vcpkg)
    subprocess.call([vcpkg, "update"])
    subprocess.call([vcpkg, "install", "freetype", "--triplet", vckpg_triplets[target]])

def build_windows(target):
    triplet = vckpg_triplets[target]
    buildPath = build_path(target)
    if target == "win-x64":
        arch = "x64"
    elif target == "win-x86":
        arch = "x86"
    elif target == "win-arm64":
        arch = "ARM64"

    cmake_cmd = ["cmake",
        "-A", arch,
        f'-DCMAKE_TOOLCHAIN_FILE={vckg_toolchain}',
        f"-DVCPKG_TARGET_TRIPLET={triplet}",
    ] + common_cmake_args(target, buildMode, True)
    subprocess.call(cmake_cmd)

    subprocess.call(["cmake", "--build", buildPath, "--config", buildMode])

    srcFolder = os.path.join(buildPath, buildMode, "cimgui.dll")
    dstFolder = os.path.join(outFolder, target, "native", "cimgui.dll")
    new_dir(dstFolder)
    shutil.copy2(srcFolder, dstFolder)

def build_mac(target):
    triplet = vckpg_triplets[target]
    buildPath = build_path(target)
    isArm64 = target == "osx-arm64"
    cmake_cmd = ["cmake",
        "-DCMAKE_OSX_ARCHITECTURES=", "arm64" if isArm64 else "x86_64",
        f'-DCMAKE_TOOLCHAIN_FILE={vckg_toolchain}',
        f"-DVCPKG_TARGET_TRIPLET={triplet}",
    ] + common_cmake_args(target, buildMode, True)
    subprocess.call(cmake_cmd)

    subprocess.call(["cmake", "--build", buildPath, "--config", buildMode])

    srcFolder = os.path.join(buildPath, "libcimgui.dylib")
    dstFolder = os.path.join(outFolder, target, "native", "cimgui.dylib")
    new_dir(dstFolder)
    shutil.copy2(srcFolder, dstFolder)

def build_linux(target):
    triplet = vckpg_triplets[target]
    buildPath = build_path(target)

    cmake_cmd = ["cmake",
        f'-DCMAKE_TOOLCHAIN_FILE={vckg_toolchain}',
        f"-DVCPKG_TARGET_TRIPLET={triplet}",
    ] + common_cmake_args(target, buildMode, True)

    if platform.machine() == "x86_64" and target == "linux-arm64":
        cmake_cmd += [ # crosscompiling
            "-DCMAKE_SYSTEM_PROCESSOR=aarch64",
            "-DCMAKE_C_COMPILER=aarch64-linux-gnu-gcc",
            "-DCMAKE_CXX_COMPILER=aarch64-linux-gnu-g++",
        ]
    subprocess.call(cmake_cmd)

    subprocess.call(["cmake", "--build", buildPath, "--config", buildMode])

    srcFolder = os.path.join(buildPath, "libcimgui.so")
    dstFolder = os.path.join(outFolder, target, "native", "cimgui.so")
    new_dir(dstFolder)
    shutil.copy2(srcFolder, dstFolder)

def build_wasm():
    if "EMSDK" in os.environ:
        emsdkPath = os.environ["EMSDK"]
    elif "EMSDK_HOME" in os.environ:
        emsdkPath = os.environ["EMSDK_HOME"]
    elif "EMSDKHOME" in os.environ:
        emsdkPath = os.environ["EMSDKHOME"]
    else:
        emsdkPath = input("Please enter the path to your Emscripten SDK: ")

    emsdkToolchain = os.path.join(emsdkPath, "upstream", "emscripten", "cmake", "Modules", "Platform", "Emscripten.cmake")
    emsdkNodePath = os.path.join(emsdkPath, "node")
    emsdkNodePath = os.path.join(emsdkNodePath, os.listdir(emsdkPath)[0])
    useNinja = not inWindows() or shutil.which("ninja.exe") != None
    buildPath = build_path(target)

    cmake_cmd = ["cmake",
        "-DCMAKE_TOOLCHAIN_FILE=" + emsdkToolchain,
        "-DCMAKE_CROSSCOMPILING_EMULATOR=" + emsdkNodePath,
        "-DCMAKE_CXX_FLAGS=-s USE_FREETYPE=0 -s WASM=1",
        "-DCMAKE_C_FLAGS=-s USE_FREETYPE=0 -s WASM=1",
        "-DCMAKE_LD_FLAGS=-s USE_FREETYPE=0",
    ] + common_cmake_args(target, buildMode, False)
    if useNinja: # will will try to use ninja (even in windows) if available
        cmake_cmd.append("-GNinja")
    subprocess.call(cmake_cmd)

    subprocess.call(["cmake", "--build", buildPath, "--config", buildMode])

    if useNinja:
        srcFolder = os.path.join(buildPath, "libcimgui.a")
    else:
        srcFolder = os.path.join(buildPath, buildMode, "libcimgui.a")
    dstFolder = os.path.join(outFolder, target, "native", "cimgui.a")
    new_dir(dstFolder)
    shutil.copy2(srcFolder, dstFolder)

    pass

if __name__ == "__main__":
    parser = argparse.ArgumentParser()
    parser.add_argument(
        "target",
        help = "Target platform to build for",
        nargs='?',
        default = "win-x64",
        choices = vckpg_triplets.keys()
    )
    parser.add_argument(
        "--build_mode",
        type = str,
        help = "Debug or Release",
        default = "Release",
        choices = ["Debug", "Release"]
    )
    args = parser.parse_args()
    target = args.target
    triplet = vckpg_triplets[target]
    buildMode = args.build_mode

    setup_vcpkg(target)
    vckg_toolchain = os.path.join(rel_path("vcpkg"), "scripts", "buildsystems", "vcpkg.cmake")
    
    outFolder = build_path("OUT")
    new_dir(outFolder)

    print("--- CMake Build ---")

    # --- Windows x64 ---
    if target == "win-x64":
        build_windows(target)

    # --- Windows arm64 ---
    if args.target == "win-arm64":
        build_windows(target)
    
    # --- Mac arm64 ---
    if args.target == "osx-arm64":
        build_mac(target)

    # --- Mac x64 ---
    if args.target == "osx-x64":
        build_mac(target)

    # --- Linux x64 ---
    if args.target == "linux-x64":
        build_linux(target)

    # --- Linux arm64 ---
    if args.target == "linux-arm64":
        build_linux(target)

    # --- WebAssembly ---
    if args.target == "browser-wasm":
        build_wasm()


