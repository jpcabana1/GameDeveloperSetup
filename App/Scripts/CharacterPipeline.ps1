param([string] $CharacterName, [string] $Path)

Set-Location $Path

mkdir $CharacterName
Set-Location $CharacterName

mkdir CharacterCreator4
mkdir MarverlousDesigner
mkdir SubstancePainter
mkdir Blender
mkdir Unreal
mkdir Reference
mkdir Release

Invoke-Item $Path