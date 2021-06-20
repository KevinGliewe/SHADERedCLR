# Beckup the current directory
$BackupPath = Get-Location

# Change directory to the plugin root
Set-Location $PSScriptRoot/../

Write-Output "Downloading runtime"
runtimedl --version-pattern "^5\.0\.3$" --output "bin" --platform Windows --architecture X64

# Restore the current directory
Set-Location $BackupPath