<#
.SYNOPSIS
	Evergine bindings generator script, (c) 2022 Evergine Team
.DESCRIPTION
	This script generates ImGui bindings used in Evergine
	It's meant to have the same behavior when executed locally as when it's executed in a CI pipeline.
.EXAMPLE
	<script> -version 2021.11.17.1-local
.LINK
	https://evergine.com/
#>

param (
	[string]$buildVerbosity = "normal",
	[string]$buildConfiguration = "Release",
	[string]$imguiGenCsprojPath = "ImguiGen\ImguiGen.csproj"
)

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
dotnet publish "$imguiGenCsprojPath" -v:$buildVerbosity -p:Configuration=$buildConfiguration
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
pushd .\ImguiGen\bin\Release\netcoreapp3.1
.\publish\ImguiGen.exe
if($?)
{
   LogDebug "END bindings generator process"
}
else
{
	LogDebug "ERROR; Bindings generation failed"
   	exit -1
}
popd
