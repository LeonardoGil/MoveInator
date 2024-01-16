using namespace System.Collections.Generic;

$headers = [Dictionary[[String],[String]]]::new();

$headers.Add("Accept", "application/vnd.github+json")
$headers.Add("X-GitHub-Api-Version", "2022-11-28")
$headers.Add("Authorization", "")

$response = Invoke-RestMethod 'https://api.github.com/repos/LeonardoGil/MoveInator/releases' -Method 'GET' -Headers $headers
$list = [Dictionary[[string],[int]]]::new();

foreach ($release in $response)
{
    $zip = $release.assets | Select-Object -First 1;

    if ($zip -eq $null)
    {
        $downloadCount = 0;
    }
    else 
    {
        $downloadCount = $zip.download_count;
    }

    $list.Add($release.name, $downloadCount);
}

$list | Write-Output;