Push-Location (Get-Location).Path

$tmpFolder = "$PSScriptRoot/../tmp"
New-Item -ItemType Directory -Path $tmpFolder -Force
Set-Location $tmpFolder

Invoke-WebRequest -Uri https://github.com/emscripten-core/emsdk/archive/master.zip -OutFile master.zip
Expand-Archive -Path master.zip -DestinationPath . -Force
.\emsdk-master\emsdk update
.\emsdk-master\emsdk install latest
.\emsdk-master\emsdk activate latest
Remove-Item master.zip

Invoke-WebRequest -Uri https://github.com/ninja-build/ninja/releases/latest/download/ninja-win.zip -OutFile ninja.zip
Expand-Archive -Path ninja.zip -DestinationPath . -Force
Remove-Item ninja.zip

Pop-Location