<#
.SYNOPSIS
	Evergine bindings NuGet Packages generator script, (c) 2022 Evergine Team
.DESCRIPTION
	This script generates NuGet packages for the low-level ImGui bindings used in Evergine
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.EXAMPLE
	<script> -versionSuffix local
.LINK
	https://evergine.com/
#>

param (
	[ValidateSet('Imgui', 'Imguizmo', 'Imnodes', 'Implot')][string]$ImX = "Imgui",
	[string]$outputFolderBase = "nupkgs",
	[string]$buildVerbosity = "normal",
	[string]$buildConfiguration = "Release",
    [string]$versionSuffix = ""
)

$ErrorActionPreference = "Stop"
. "$PSScriptRoot\ps_support.ps1"

# Set working directory
Push-Location (Get-Location).Path
Set-Location $PSScriptRoot\..\Generator

$csprojPath = "Evergine.Bindings.$($ImX)\Evergine.Bindings.$($ImX).csproj"

# Utility functions
function LogDebug($line)
{ Write-Host "##[debug] $line" -Foreground Blue -Background Black
}

# calculate version
$version = "$(Get-Date -Format "yyyy.M.d").$([string]([int]$(Get-Date -Format "HH")*60+[int]$(Get-Date -Format "mm")))"

if ($versionSuffix -ne "") {
	$version = "$version-$versionSuffix"
}

# Show variables
LogDebug "############## VARIABLES ##############"
LogDebug "Version.............: $version"
LogDebug "Build configuration.: $buildConfiguration"
LogDebug "Build verbosity.....: $buildVerbosity"
LogDebug "Output folder.......: $outputFolderBase"
LogDebug "#######################################"

# Create output folder
$outputFolder = Join-Path $outputFolderBase $version
New-Item -ItemType Directory -Force -Path $outputFolder
$absoluteOutputFolder = Resolve-Path $outputFolder

$symbols = "false"
if($buildConfiguration -eq "Debug")
{
	$symbols = "true"
}

# Generate packages
LogDebug "START packaging process"
dotnet pack "$csprojPath" -v:$buildVerbosity -p:Configuration=$buildConfiguration -p:PackageOutputPath="$absoluteOutputFolder" -p:IncludeSymbols=$symbols -p:Version=$version
if($?)
{
   LogDebug "END packaging process"
}
else
{
	LogDebug "ERROR; packaging failed"
   	exit -1
}

Pop-Location
