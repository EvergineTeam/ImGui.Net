# ImGui.Net

This repository contains a thin low-level autogenerated C# bindings for Imgui used by Evergine.
You will find c# bindings of the most popular imgui libraries as well, Imguizmo, Implot and Imnodes.

## Build Status
[![Build cimgui Libraries](https://github.com/EvergineTeam/ImGui.Net/actions/workflows/cd.yml/badge.svg)](https://github.com/EvergineTeam/ImGui.Net/actions/workflows/cd.yml)
[![Nuget](https://img.shields.io/nuget/v/Evergine.Bindings.Imgui?logo=nuget)](https://www.nuget.org/packages/Evergine.Bindings.Imgui)

## How it works

This automated binding are generated based on the cimgui project json outputs:
- [cimgui](https://github.com/cimgui/cimgui)
- [cimguzimo](https://github.com/cimgui/cimguizmo)
- [cimplot](https://github.com/cimgui/cimplot)
- [cimnodes](https://github.com/cimgui/cimnodes)

which are c-api wrapper autogenerated from the original github projects:
- [imgui](https://github.com/cimgui/cimgui)
- [imguizmo](https://github.com/cimgui/cimguizmo)
- [implot](https://github.com/cimgui/cimplot)
- [imnodes](https://github.com/Nelarius/imnodes)

## Github Workflow
The github workflow allows to generate new Nuget versions easily.

## Test

Check at `Generator\Test` an Evergine project created with the default template which uses the bindings.

![capture4](https://user-images.githubusercontent.com/1783366/177344683-a5d7a2c0-7afa-4cb5-ab15-cc54c9dcc24c.png)
![capture2](https://user-images.githubusercontent.com/1783366/177344701-ca0e36fb-85fc-4429-aba6-715beb8578df.png)
![capture1](https://user-images.githubusercontent.com/1783366/177344719-8b570a1a-efea-43c6-ae5f-1143bd0643b6.png)
![capture3](https://user-images.githubusercontent.com/1783366/177344724-b2018558-9bc1-44dc-a694-26210924a07e.png)

## Development

- Optionally, update all submodules.
- Then, build cimgui and its native extensions running `.\scripts\deploy-win-native.ps1 -buildImgui -buildExtensions`
- Use visual studio to compile and generate every binding.

**NOTE:** Extensions bindings use latest Imgui nuget package on Nuget.org.

## Platforms
We are working to add support to all this plaforms:

- [x] Windows x86, x64
- [x] Linux x64
- [x] MacOS
- [x] WebAssembly
- [ ] iOS
- [ ] Android
