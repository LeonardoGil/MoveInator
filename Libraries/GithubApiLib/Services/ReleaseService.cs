using GithubApiLib.Domains.Constants;
using GithubApiLib.Domains.Entities;
using GithubApiLib.Services.Interfaces;
using System.Text.Json;

namespace GithubApiLib.Services
{
    public class ReleaseService : IReleaseService
    {
        private readonly IRequestGithubAPIService requestGithubAPIService;

        public ReleaseService(IRequestGithubAPIService requestGithubAPIService)
        {
            this.requestGithubAPIService = requestGithubAPIService;
        }

        public async Task<Release> LastReleaseAsync()
        {
            var url = new Uri(UrlConsts.UrlAPIBase + UrlConsts.UrlLastRelease);

            var request = requestGithubAPIService.GenerateRequest(HttpMethod.Get, url);
            var client = new HttpClient();

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Release>(responseBody);
        }

        public async Task<List<Release>> ListReleasesAsync()
        {
            var url = new Uri(UrlConsts.UrlAPIBase + UrlConsts.UrlListReleases);

            var request = requestGithubAPIService.GenerateRequest(HttpMethod.Get, url);
            var client = new HttpClient();

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Release>>(responseBody);
        }
    }
}
