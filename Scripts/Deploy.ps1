using namespace System.IO;
using namespace System.Reflection;

# Pega o diretorio do projeto
$pathLocation = Get-Location;
$pathProject = [Directory]::GetParent($pathLocation).FullName;

$pathCSProj = [Path]::Combine($pathProject, 'MoveInatorForms', 'MoveInatorForms.csproj');
$pathArtefatos = '..\Artefatos';

dotnet build $pathCSProj -c 'Release' -o $pathArtefatos;

$pathTemplates = [Path]::Combine($pathProject, 'MoveInatorForms', 'Templates');

Copy-Item -Path "$pathTemplates\*" -Destination $pathArtefatos;

$version = (Get-Item '..\Artefatos\MoveInatorForms.exe').VersionInfo.FileVersion;
$filePath = "$pathProject\MoveInator_Pre-Release@$version.zip";

Start-Process 'C:\Program Files\7-Zip\7z.exe' -ArgumentList @('a', '-tzip', $filePath, "$pathArtefatos\*");

Write-Host "Artefato gerado." -ForegroundColor Green;
Write-Output $filePath;

Remove-Item $pathArtefatos;