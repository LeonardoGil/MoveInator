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

        public List<Release> ListReleases()
        {
            var url = new Uri(UrlConsts.UrlAPIBase + UrlConsts.UrlListReleases);

            var request = requestGithubAPIService.GenerateRequest(HttpMethod.Get, url);
            var client = new HttpClient();

            var response = client.SendAsync(request).Result;
            response.EnsureSuccessStatusCode();

            string responseBody = response.Content.ReadAsStringAsync().Result;

            return JsonSerializer.Deserialize<List<Release>>(responseBody);
        }
    }
}
