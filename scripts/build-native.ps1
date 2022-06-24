<#
.SYNOPSIS
	Build cimX definitions and native libraries for windows platforms
.DESCRIPTION
	This script builds cimX definitions and native libraries for windows platforms.
    By default, it builds cimgui on windows x64 platform.
.EXAMPLE
	<script> -buildArch x86
.LINK
	https://evergine.com
#>

param (
  [ValidateSet('Debug', 'Release')][string]$buildConfig = "Release",
  [ValidateSet('x86', 'x64', 'ARM', 'ARM64')][string]$buildArch = "x64"
)

$ErrorActionPreference = "Stop"
. "$PSScriptRoot\ps_support.ps1"

switch ( $buildArch ) {
  'x86' { $BUILD_CMAKE_GENERATOR_PLATFORM = 'Win32' }
  'x64' { $BUILD_CMAKE_GENERATOR_PLATFORM = '' }
  'ARM' { $BUILD_CMAKE_GENERATOR_PLATFORM = 'ARM' }
  'ARM64' { $BUILD_CMAKE_GENERATOR_PLATFORM = 'ARM64' }
}

function Build-cimgui {
  [CmdletBinding()]
  param (
    [bool]$extensions = $false
  )

  # Set working directory
  Push-Location (Get-Location).Path
  Set-Location $PSScriptRoot\..\NativeLibraries

  if ($extensions) {
    Set-Location ./extensions
  }
  else {
    Set-Location ./cimgui
  }

  $buildPath = ".\build\$buildArch"
  if (!(test-path -PathType container $buildPath)) {
    New-Item -ItemType Directory -Path $buildPath
  }

  Set-Location $buildPath
  cmake -DCMAKE_GENERATOR_PLATFORM="$BUILD_CMAKE_GENERATOR_PLATFORM" -G 'Visual Studio 17 2022' ..\..

  Write-Output "Calling cmake --build . --config $buildConfig"
  cmake --build . --config $buildConfig

  Pop-Location
}

# build cimgui
Build-cimgui

# build extensions
Build-cimgui -extensions $true
