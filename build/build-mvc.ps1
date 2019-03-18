# COMMON PATHS

$buildFolder = (Get-Item -Path "./" -Verbose).FullName
$slnFolder = Join-Path $buildFolder "../"
$outputFolder = Join-Path $buildFolder "outputs"
$webMvcFolder = Join-Path $slnFolder "src/Tolo.MyAbp.Web.Mvc"

## CLEAR ######################################################################

Remove-Item $outputFolder -Force -Recurse -ErrorAction Ignore
New-Item -Path $outputFolder -ItemType Directory

## RESTORE NUGET PACKAGES #####################################################

Set-Location $slnFolder
dotnet restore

## PUBLISH WEB MVC PROJECT ###################################################

Set-Location $webMvcFolder
dotnet publish --output (Join-Path $outputFolder "Mvc") --configuration Release

## CREATE DOCKER IMAGES #######################################################

# Mvc
Set-Location (Join-Path $outputFolder "Mvc")

docker rmi tolo/admin -f
docker build -t tolo/admin .

## DOCKER COMPOSE FILES #######################################################

Copy-Item (Join-Path $slnFolder "docker/webfarm/*.*") $outputFolder

## FINALIZE ###################################################################

Set-Location $outputFolder