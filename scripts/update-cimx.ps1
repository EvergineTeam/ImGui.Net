<#
.SYNOPSIS
	Updates cimX submodules.
.DESCRIPTION
	This script updates cimX submodules and set github actions outputs for imgui and extensions.
.EXAMPLE
	<script>
.LINK
	https://evergine.com
#>

param (
  [ValidateSet('Debug', 'Release')][string]$buildConfig = "Release"
)

$ErrorActionPreference = "Stop"
. "$PSScriptRoot\ps_support.ps1"

$archs = @('x86', 'x64') #, 'ARM', 'ARM64')
$main = "imgui"
$extensions = @("imguizmo", "imnodes", "implot")


$TextInfo = (Get-Culture).TextInfo

#region update modules

# Set working directory
Push-Location (Get-Location).Path
Set-Location $PSScriptRoot\..\NativeLibraries

# update cimgui & register for build if changes
Push-Location ".\cimgui"
$currentRef = $(git rev-parse HEAD)
git pull origin master | Out-Null
if ($(git rev-parse HEAD) -ne $currentRef) {
  Write-Output "cimgui has been updated."
  Write-Output "::set-output name=BUILD_CIMGUI::true"
}
else {
  Write-Output "cimgui already up to date."
  Write-Output "::set-output name=BUILD_CIMGUI::false"
}
Pop-Location

# update submodules & register for build if changes
$buildExtensions = $false
foreach ($extension in $extensions) {
  Push-Location ".\extensions\c$extension"
  $currentRef = $(git rev-parse HEAD)
  git pull origin master | Out-Null
  if ($(git rev-parse HEAD) -ne $currentRef) {
    Write-Output "$extension has been updated."
    $buildExtensions = $true
  }
  else {
    Write-Output "$extension already up to date."
  }
  Pop-Location
}

if ($buildExtensions) {
  Write-Output "::set-output name=BUILD_EXT::true"
}
else {
  Write-Output "::set-output name=BUILD_EXT::false"
}
Pop-Location

#endregion
