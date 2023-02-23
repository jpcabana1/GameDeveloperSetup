param([string] $AssetName, [string] $Path)

Set-Location $Path

mkdir $AssetName
Set-Location $AssetName

mkdir ExportRelease
mkdir Reference
mkdir SubstancePainter

Set-Location SubstancePainter
mkdir Import
Set-Location ..
