<#
.SYNOPSIS
	Build cimX definitions and native libraries for windows platforms
.DESCRIPTION
	This script builds cimX definitions and native libraries for windows platforms.
    By default, it builds cimgui on windows x64 platform.
.EXAMPLE
	<script> -localFeedPath D:\evergineLocalFeed -versionSuffix mytest
.LINK
	https://evergine.com
#>

param (
  [ValidateSet('cimgui', 'cimguizmo', 'cimnodes', 'cimplot')][string]$cimX = "cimgui",
  [ValidateSet('Debug', 'Release')][string]$buildConfig = "Release",
  [ValidateSet('x86', 'x64', 'ARM', 'ARM64')][string]$buildArch = "x64"
)

$ErrorActionPreference = "Stop"
. "$PSScriptRoot\..\ps_support.ps1"

switch ( $buildArch ) {
  'x86' { $BUILD_CMAKE_GENERATOR_PLATFORM = 'Win32' }
  'x64' { $BUILD_CMAKE_GENERATOR_PLATFORM = '' }
  'ARM' { $BUILD_CMAKE_GENERATOR_PLATFORM = 'ARM' }
  'ARM64' { $BUILD_CMAKE_GENERATOR_PLATFORM = 'ARM64' }
}

#region Build cimgui

# Set working directory
Push-Location (Get-Location).Path
Set-Location $PSScriptRoot

Set-Location ./cimgui

$buildPath = ".\build\$buildArch"
if (!(test-path -PathType container $buildPath)) {
  New-Item -ItemType Directory -Path $buildPath
}


Set-Location $buildPath
cmake -DCMAKE_GENERATOR_PLATFORM="$BUILD_CMAKE_GENERATOR_PLATFORM" -G 'Visual Studio 17 2022' ..\..

Write-Output "Calling cmake --build . --config $buildConfig"
cmake --build . --config $buildConfig

Pop-Location

#endregion

#region Build extensions

# Set working directory
Push-Location (Get-Location).Path
Set-Location $PSScriptRoot

Set-Location ./extensions

$buildPath = ".\build\$buildArch"
if (!(test-path -PathType container $buildPath)) {
  New-Item -ItemType Directory -Path $buildPath
}

Set-Location $buildPath
cmake -DCMAKE_GENERATOR_PLATFORM="$BUILD_CMAKE_GENERATOR_PLATFORM" -G 'Visual Studio 17 2022' ..\..

Write-Output "Calling cmake --build . --config $buildConfig"
cmake --build . --config $buildConfig

Pop-Location

#endregion