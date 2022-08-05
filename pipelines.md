1. Compilar cimgui para cada plataforma.
    1.1 Arrancar un agente para cada plataforma
    1.2 Actualizar submodulo cimgui a la última versión
    1.3 Utilizar build-native script ([TillAlex/ImGui.NET-nativebuild: Windows/macOS/Linux/iOS/Android build automation for cimgui. Used to package up ImGui.NET. (github.com)](https://github.com/TillAlex/ImGui.NET-nativebuild)) para compilar
    1.4 Copiar generator/output `definitions.json` y `structs_and_enums.json` hacia imguiGen/Jsons (copiar los jsons de una sóla plataforma, x ej win64).
    1.5 Copiar dlls nativas de cada arquitectura en Evergine.Bindings.Imgui/runtimes/[Platform]
    1.6 Commit & push los cambios.

2. Compilar y ejecutar ImguiGen
    2.2 Commit & Push
3. Compilar Evergine.Bindings.Imgui, generar nugets y publicar en nightly/nuget.org


oy2dgw5plwvuait4izaqheumacftezqebnpprn565utplq

cmake .. -DBOOST_ROOT="Z:\opt\Boost\boost_1_79_0" -DBOOST_LIBRARYDIR="Z:\opt\Boost\boost_1_79_0" -DOpenCV_DIR="Z:\opt\opencv-4.5.5\build" -DCMAKE_MAKE_PROGRAM="C:\ProgramData\chocolatey\bin\make.exe"

-G "Visual Studio 17 2022"
-A x64
