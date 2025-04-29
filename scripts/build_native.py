import os
import sys
import subprocess
import shutil
import zipfile
import urllib.request

ReleaseMode = "Release"
EMSDK_VERSION = "4.0.7"
EMSCRIPTEN_SDK_URL = f"https://github.com/emscripten-core/emsdk/archive/refs/tags/{EMSDK_VERSION}.zip"

libName_to_bindingName = {
    "cimgui": "Evergine.Bindings.Imgui",
    "cimplot": "Evergine.Bindings.Implot",
    "cimnodes": "Evergine.Bindings.Imnodes",
    "cimguizmo": "Evergine.Bindings.Imguizmo",
}

def scriptsDir(): return os.path.dirname(os.path.abspath(__file__))
def rootDir(): return os.path.abspath(os.path.join(scriptsDir(), ".."))
def nativeLibsDir(): return os.path.join(rootDir(), "NativeLibraries")
def tmpDir(): return os.path.join(rootDir(), "tmp")

def makeTmpDir():
    tmp_dir = tmpDir()
    if not os.path.exists(tmp_dir):
        os.makedirs(tmp_dir)
    return tmp_dir

def compile_for_wasm(libName="cimgui"):
    makeTmpDir()
    zipPath = os.path.join(tmpDir(), "emsdk.zip")
    emsdkPath = os.path.join(tmpDir(), f"emsdk-{EMSDK_VERSION}")
    urllib.request.urlretrieve(EMSCRIPTEN_SDK_URL, zipPath)

    #decompress the zip file
    with zipfile.ZipFile(zipPath, 'r') as zip_ref:
        zip_ref.extractall(tmpDir())
    
    emsdkScriptExtension = ".bat" if sys.platform.startswith("win") else ""
    emsdkScriptPath = os.path.join(emsdkPath, f"emsdk{emsdkScriptExtension}")
    
    subprocess.call([emsdkScriptPath, "install", "latest"])
    subprocess.call([emsdkScriptPath, "activate", "latest"])
    
    if libName == "cimgui":
        srcPath = os.path.join(nativeLibsDir(), "cimgui")
    else:
        srcPath = os.path.join(nativeLibsDir(), "extensions", "imgui")
    buildPath = os.path.join(srcPath, "build", "wasm")
    
    emsdk_env = os.path.join(emsdkPath, "emsdk_env.bat" if sys.platform.startswith("win") else "emsdk_env.sh")
    subprocess.call([emsdk_env])

    toolchainFile = os.path.join(emsdkPath, "upstream", "emscripten", "cmake", "Modules", "Platform", "Emscripten.cmake")
    crossCompilingEmulator = os.path.join(emsdkPath, "node", "20.18.0_64bit", "bin", "node.exe")

    subprocess.call(["cmake",
        "-S", srcPath,
        "-B", buildPath,
        f'-DCMAKE_TOOLCHAIN_FILE={toolchainFile}',
        f'-DCMAKE_CROSSCOMPILING_EMULATOR={crossCompilingEmulator}',
        "-DVCPKG_TARGET_TRIPLET=wasm32-emscripten",
        "-DIMGUI_WCHAR32=ON",
        f"-DCMAKE_BUILD_TYPE={ReleaseMode}",
        "-DIMGUI_FREETYPE=OFF",
        f'-DCMAKE_CXX_FLAGS="-s USE_FREETYPE=0 -s WASM=1"',
        f'-DCMAKE_C_FLAGS="-s USE_FREETYPE=0 -s WASM=1"',
        #f'-DCMAKE_LD_FLAGS="-s USE_FREETYPE=0 -s WASM=1"'
    ])
    
    subprocess.call(["cmake", "--build", buildPath, "--config", ReleaseMode])

    srcLibPath = os.path.join(buildPath, ReleaseMode, f"{libName}.a")
    dstLibPath = os.path.join(rootDir(), "Generator", libName_to_bindingName[libName], "runtimes", "browser-wasm", "native", f"{libName}.a")
    if os.path.exists(dstLibPath):
        os.remove(dstLibPath)
    shutil.copy(srcLibPath, dstLibPath)


compile_for_wasm()