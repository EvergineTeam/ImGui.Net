<#
.SYNOPSIS
	Build cimX definitions and native libraries for Wasm
.DESCRIPTION
	This script builds cimX definitions and native libraries for Wasm.
    If parameter extensions is set, it compiles the extensions instead
.EXAMPLE
	<script> -buildConfig Debug
.LINK
	https://evergine.com
#>

param (
  [switch]$extensions = $false,
  [ValidateSet('Debug', 'Release')][string]$buildConfig = "Release"
)

$ErrorActionPreference = "Stop"
. "$PSScriptRoot\ps_support.ps1"

# Set working directory
Push-Location (Get-Location).Path
Set-Location $PSScriptRoot\..\NativeLibraries

if ($extensions) {
  Set-Location ./extensions
}
else {
  Set-Location ./cimgui
}

$buildPath = ".\build\wasm"
if (!(test-path -PathType container $buildPath)) { # create build directory if it doesn't exist
  New-Item -ItemType Directory -Path $buildPath
}

$EmSdkPath = "$PSScriptRoot/../tmp/emsdk-master"
$ToolchainFile = "$EmSdkPath/upstream/emscripten/cmake/Modules/Platform/Emscripten.cmake"
$NinjaPath = "$PSScriptRoot/../tmp/ninja.exe"

Set-Location $buildPath
cmake -B "." -GNinja -DCMAKE_BUILD_TYPE="$buildConfig" -GNinja -DCMAKE_TOOLCHAIN_FILE="$ToolchainFile" -DCMAKE_MAKE_PROGRAM="$NinjaPath" ../..

Write-Output "Calling cmake --build . --config $buildConfig"
cmake --build . --config $buildConfig

Pop-Location
