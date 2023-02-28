param(
    [string] $ScriptsPath,
    [string] $RepositoryUrl, 
    [string] $RepositoryName,
    [string] $Path
)

Set-Location $Path
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

Copy-Item "${ScriptsPath}\Resources\.gitignore" -Destination ".\Project"
Copy-Item "${ScriptsPath}\Resources\.gitattributes" -Destination "."

Set-Location ..

Invoke-Item $Path