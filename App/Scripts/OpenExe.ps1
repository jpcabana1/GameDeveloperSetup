param(
    [string] $Path,
    [string] $Exe
)

Set-Location $Path
Start-Process -FilePath $Exe
