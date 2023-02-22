param(
    #[string] $EngineEditorPath, 
    [string] $GameDevPath, 
    [string] $RepositoryUrl, 
    [string] $RepositoryName
)

git clone $RepositoryUrl
Set-Location $RepositoryName

mkdir Docs
mkdir Assets
mkdir Characters
mkdir Project

Set-Location Docs
mkdir GDD
mkdir References
Set-Location .. 

Copy-Item "${GameDevPath}\Assets\AssetSetup.ps1" -Destination ".\Assets"
Copy-Item "${GameDevPath}\CharacterPipeline\CharacterPipelineV2.ps1" -Destination ".\Characters"
Copy-Item "${GameDevPath}\Games\.gitignore" -Destination ".\Project"
Copy-Item "${GameDevPath}\Games\.gitattributes" -Destination "."


#Invoke-Expression -Command "${EngineEditorPath}\UnrealEditor.exe"

Set-Location ..