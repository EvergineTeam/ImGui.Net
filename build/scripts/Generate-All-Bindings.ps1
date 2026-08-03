<#
.SYNOPSIS
	Evergine all bindings generator script, (c) 2025 Evergine Team
.DESCRIPTION
	This script generates all bindings (Imgui, Implot, Imnodes, Imguizmo) used in Evergine
	by invoking Generate-Bindings-DotNet.ps1 for each generator.
.PARAMETER BuildVerbosity
	Build verbosity level for dotnet commands
.PARAMETER BuildConfiguration
	Build configuration (Debug/Release)
.PARAMETER TargetFramework
	Target framework for the generator (default: net10.0)
.PARAMETER RuntimeIdentifier
	Runtime identifier for the generator (e.g., win-x64)
.EXAMPLE
	.\Generate-All-Bindings.ps1
.EXAMPLE
	.\Generate-All-Bindings.ps1 -BuildConfiguration Debug -BuildVerbosity detailed
.LINK
	https://evergine.com/
#>

param (
    [string]$BuildVerbosity = "normal",         # Verbosity for dotnet build/publish (e.g., minimal, normal, detailed)
    [string]$BuildConfiguration = "Release",   # Build configuration (Release/Debug)
    [string]$TargetFramework = "net10.0",      # Target framework for the generator (default: net10.0)
    [string]$RuntimeIdentifier = ""            # Runtime identifier for the generator (e.g., win-x64) - empty by default
)

# Get the script directory and paths
$scriptPath = Split-Path -Parent $MyInvocation.MyCommand.Path
$generateBindingsScript = Join-Path $scriptPath "Generate-Bindings-DotNet.ps1"
$generatorBasePath = Join-Path (Split-Path -Parent (Split-Path -Parent $scriptPath)) "Generator"

# Define the generators to process
$generators = @(
    @{
        Name    = "Imgui"
        Project = Join-Path $generatorBasePath "ImguiGen\ImguiGen.csproj"
    },
    @{
        Name    = "Implot"
        Project = Join-Path $generatorBasePath "ImplotGen\ImplotGen.csproj"
    },
    @{
        Name    = "Imnodes"
        Project = Join-Path $generatorBasePath "ImnodesGen\ImnodesGen.csproj"
    },
    @{
        Name    = "Imguizmo"
        Project = Join-Path $generatorBasePath "ImguizmoGen\ImguizmoGen.csproj"
    }
)

Write-Host "Starting generation of all bindings..." -ForegroundColor Green
Write-Host "Configuration: $BuildConfiguration" -ForegroundColor Cyan
Write-Host "Verbosity: $BuildVerbosity" -ForegroundColor Cyan
Write-Host "Target Framework: $TargetFramework" -ForegroundColor Cyan
Write-Host "Runtime Identifier: $RuntimeIdentifier" -ForegroundColor Cyan
Write-Host ""

$totalGenerators = $generators.Count
$currentGenerator = 0
$failedGenerators = @()

foreach ($generator in $generators) {
    $currentGenerator++
    Write-Host "[$currentGenerator/$totalGenerators] Processing $($generator.Name) generator..." -ForegroundColor Yellow
    
    # Verify the project exists
    if (-not (Test-Path $generator.Project)) {
        Write-Host "ERROR: Generator project not found at: $($generator.Project)" -ForegroundColor Red
        $failedGenerators += $generator.Name
        continue
    }
    
    try {
        # Invoke the binding generator script
        & $generateBindingsScript `
            -BuildVerbosity $BuildVerbosity `
            -BuildConfiguration $BuildConfiguration `
            -GeneratorProject $generator.Project `
            -GeneratorName $generator.Name `
            -TargetFramework $TargetFramework `
            -RuntimeIdentifier $RuntimeIdentifier
        
        if ($LASTEXITCODE -eq 0) {
            Write-Host "$($generator.Name) bindings generated successfully!" -ForegroundColor Green
        }
        else {
            Write-Host "$($generator.Name) binding generation failed!" -ForegroundColor Red
            $failedGenerators += $generator.Name
        }
    }
    catch {
        Write-Host "Error processing $($generator.Name): $($_.Exception.Message)" -ForegroundColor Red
        $failedGenerators += $generator.Name
    }
    
    Write-Host ""
}

# Summary
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "BINDING GENERATION SUMMARY" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan

if ($failedGenerators.Count -eq 0) {
    Write-Host "All $totalGenerators generators completed successfully!" -ForegroundColor Green

    # C# cannot safely call a C variadic function: on AArch64 variadic arguments use a
    # different calling convention from named ones, so a fixed managed signature bound
    # to a variadic native symbol is wrong at the ABI level even though it links and
    # works on x64. cimgui emits a non-variadic companion for each of them, but those
    # companions are absent from definitions.json, so the generators above cannot
    # produce the mapping and would silently rebind ImGui.Text and friends.
    #
    # See cimgui/cimgui#323. When the definitions carry the companions this step
    # becomes a no-op and can be deleted.
    Write-Host ""
    Write-Host "Binding variadic imports to their zero-argument entry points..." -ForegroundColor Cyan
    $fixup = Join-Path $PSScriptRoot "Fix-VariadicEntryPoints.py"
    python $fixup
    if ($LASTEXITCODE -ne 0) {
        Write-Host "ERROR: variadic entry point mapping failed" -ForegroundColor Red
        exit 1
    }

    exit 0
}
else {
    Write-Host "Successful: $($totalGenerators - $failedGenerators.Count)/$totalGenerators" -ForegroundColor Green
    Write-Host "Failed: $($failedGenerators.Count)/$totalGenerators" -ForegroundColor Red
    Write-Host "Failed generators: $($failedGenerators -join ', ')" -ForegroundColor Red
    exit 1
}