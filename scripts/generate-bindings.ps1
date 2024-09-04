<#
.SYNOPSIS
	Evergine bindings generator script, (c) 2022 Evergine Team
.DESCRIPTION
	This script generates ImX bindings used in Evergine
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.EXAMPLE
	<script> -version 2021.11.17.1-local
.LINK
	https://evergine.com/
#>

param (
	[ValidateSet('Imgui', 'Imguizmo', 'Imnodes', 'Implot')][string]$ImX = "Imgui",
	[string]$buildVerbosity = "normal",
	[string]$buildConfiguration = "Release"
)

$ErrorActionPreference = "Stop"
. "$PSScriptRoot\ps_support.ps1"

# Set working directory
Push-Location (Get-Location).Path
Set-Location $PSScriptRoot\..\Generator

$imxGenCsprojPath = "$($ImX)Gen\$($ImX)Gen.csproj"

# Utility functions
function LogDebug($line)
{ Write-Host "##[debug] $line" -Foreground Blue -Background Black
}

# Show variables
LogDebug "############## VARIABLES ##############"
LogDebug "Build configuration.: $buildConfiguration"
LogDebug "Build verbosity.....: $buildVerbosity"
LogDebug "#######################################"

# Build generator
LogDebug "START generator build process"
dotnet publish "$imxGenCsprojPath" -v:$buildVerbosity -p:Configuration=$buildConfiguration
if($?)
{
   	LogDebug "END generator build process"
}
else
{
	LogDebug "ERROR; Generator build failed"
   	exit -1
}

LogDebug "START bindings generator process"
$cmd = ".\publish\$($ImX)Gen.exe"
Push-Location .\$($ImX)Gen\bin\Release\net8.0
$($cmd)
if($?)
{
   	LogDebug "END bindings generator process"
}
else
{
	LogDebug "ERROR; Bindings generation failed"
	exit -1
}
Pop-Location

Pop-Location
