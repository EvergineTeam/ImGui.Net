# This script runs all the generators for the bindings

import os, subprocess

def scriptsDir(): return os.path.dirname(os.path.abspath(__file__))
def rootDir(): return os.path.abspath(os.path.join(scriptsDir(), ".."))

libs = ["Imgui", "Implot", "Imnodes", "Imguizmo"]
for lib in libs:
    generatorPath = os.path.join(rootDir(), "Generator", f"{lib}Gen")
    csprojPath = os.path.join(generatorPath, f"{lib}Gen.csproj")
    subprocess.call(["dotnet", "publish", csprojPath, "-v:normal", "-p:Configuration=Release"])

    publishPath = os.path.join(generatorPath, "bin", "Release", "net8.0")
    os.chdir(publishPath)
    subprocess.call([f"{publishPath}/publish/{lib}Gen.exe"], shell=True)