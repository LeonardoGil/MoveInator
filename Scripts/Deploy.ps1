function Deploy-MoveInator {
    param (
        [Parameter(Mandatory, Position=0)]
        [ValidateNotNullOrEmpty()]
        [string]
        $version,

        [Parameter(Mandatory, Position=1)]
        [ValidateNotNullOrEmpty()]
        [string]
        $pathProject
    )

    $pathRelease = "$pathProject\MoveInatorForms\bin\Release";
    $pathBuild = "$pathRelease\net6.0-windows";
    $pathTemplates = "$pathProject\MoveInatorForms\Templates";

    Copy-Item -Path "$pathTemplates\*" -Destination $pathBuild;

    $filePath = "$pathRelease\MoveInator_$version.zip";

    Start-Process 'C:\Program Files\7-Zip\7z.exe' -ArgumentList @('a', '-tzip', $filePath, "$pathBuild\*");

    Write-Host "Artefato gerado." -ForegroundColor Green;
    Write-Output $filePath;
}