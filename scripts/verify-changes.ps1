<#
.SYNOPSIS
	Verify if there has been changes in the repository
.DESCRIPTION
	This script is necessary because dlls have changes every time they are created, even if they are the same.
  It outputs true or false in Github Actions notation on the variable 'files_changed'.
.EXAMPLE
	<script>
.LINK
	https://evergine.com
#>

$ErrorActionPreference = "Stop"
. "$PSScriptRoot\ps_support.ps1"

$files_changed = $(git status --porcelain -- :!*.dll)

if ($files_changed -ne $null) {
  Write-Output "Changes detected"
  Write-Output "::set-output name=files_changed::true"
}
else {
  Write-Output "No relevant changes detected"
  Write-Output "::set-output name=files_changed::false"
}
