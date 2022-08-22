<#
.SYNOPSIS
	Updates cimX definitions and native libraries.
.DESCRIPTION
	This script updates cimX definitions and native libraries.
.EXAMPLE
	<script> -buildImgui -buildExtensions
.LINK
	https://evergine.com
#>

param (
  [ValidateSet('Debug', 'Release')][string]$buildConfig = "Release",
  [switch]$buildImgui = $false,
  [switch]$buildExtensions = $false
)

$ErrorActionPreference = "Stop"
. "$PSScriptRoot\ps_support.ps1"

$archs = @('x86', 'x64') #, 'ARM', 'ARM64')
$main = "imgui"
$extensions = @("imguizmo", "imnodes", "implot")


$TextInfo = (Get-Culture).TextInfo

#region build extensions
if ($buildImgui) {
  # Set working directory
  Push-Location (Get-Location).Path
  Set-Location $PSScriptRoot

  foreach ($arch in $archs) {
    Write-Output "Building cimgui $arch..."
    ./build-win-cimx-native.ps1 -buildArch $arch -buildConfig $buildConfig
    if (-Not $?) {
      exit $lastexitcode
    }

    Copy-Item ..\NativeLibraries\cimgui\build\$arch\$buildConfig\*.dll ..\Generator\Evergine.Bindings.Imgui\runtimes\win-$arch\native\
  }
  Copy-Item ..\NativeLibraries\cimgui\generator\output\*.json ..\Generator\ImguiGen\Jsons\

  Pop-Location
}

if ($buildExtensions) {
  # Set working directory
  Push-Location (Get-Location).Path
  Set-Location $PSScriptRoot

  foreach ($arch in $archs) {
    Write-Output "Building extensions $arch..."
    ./build-win-cimx-native.ps1 -buildArch $arch -buildConfig $buildConfig -extensions
    if (-Not $?) {
      exit $lastexitcode
    }

    foreach ($extension in $extensions) {
      Copy-Item ..\NativeLibraries\extensions\build\$arch\$buildConfig\c$($extension).dll ..\Generator\Evergine.Bindings.$($TextInfo.ToTitleCase($extension))\runtimes\win-$arch\native\
    }
  }
  foreach ($extension in $extensions) {
    Copy-Item ..\NativeLibraries\extensions\c$($extension)\generator\output\*.json ..\Generator\$($TextInfo.ToTitleCase($extension))Gen\Jsons\
  }

  Pop-Location
}

#endregion
