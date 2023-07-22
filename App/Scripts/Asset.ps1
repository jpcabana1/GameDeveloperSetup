param([string] $AssetName, [string] $Path)

Set-Location $Path

mkdir $AssetName
Set-Location $AssetName

mkdir Release
mkdir Reference
mkdir SubstancePainter

Invoke-Item $Path