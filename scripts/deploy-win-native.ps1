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

    $dstDir = "..\Generator\Evergine.Bindings.Imgui\runtimes\win-$arch\native\"
    New-Item -ErrorAction Ignore -Type dir -Path $dstDir
    Copy-Item ..\NativeLibraries\cimgui\build\$arch\$buildConfig\*.dll $dstDir
  }

  Write-Output "Building cimgui wasm..."
  ./build-wasm-cimx-native.ps1 -buildConfig $buildConfig
  if (-Not $?) {
    exit $lastexitcode
  }
  $dstDir = "..\Generator\Evergine.Bindings.Imgui\runtimes\browser-wasm\"
  New-Item -ErrorAction Ignore -Type dir -Path $dstDir
  Copy-Item "..\NativeLibraries\cimgui\build\wasm\*.a" $dstDir

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
      $dstPath = "..\Generator\Evergine.Bindings.$($TextInfo.ToTitleCase($extension))\runtimes\win-$arch\native\"
      New-Item -ErrorAction Ignore -Type dir -Path $dstPath
      Copy-Item ..\NativeLibraries\extensions\build\$arch\$buildConfig\c$($extension).dll $dstPath
    }
  }

  Write-Output "Building extensions wasm..."
  ./build-wasm-cimx-native.ps1 -buildConfig $buildConfig -extensions
  if (-Not $?) {
    exit $lastexitcode
  }
  foreach ($extension in $extensions) {
    $dstPath = "..\Generator\Evergine.Bindings.$($TextInfo.ToTitleCase($extension))\runtimes\browser-wasm\"
    New-Item -ErrorAction Ignore -Type dir -Path $dstPath
    Copy-Item "..\NativeLibraries\extensions\build\wasm\c$($extension).a" $dstPath
  }

  foreach ($extension in $extensions) {
    Copy-Item ..\NativeLibraries\extensions\c$($extension)\generator\output\*.json ..\Generator\$($TextInfo.ToTitleCase($extension))Gen\Jsons\
  }

  Pop-Location
}

#endregion
