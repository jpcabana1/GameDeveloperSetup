param([string] $AssetName)

mkdir $AssetName
Set-Location $AssetName

mkdir Export
mkdir Reference

Set-Location ..