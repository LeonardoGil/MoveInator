using GithubApiLib.Domains.Constants;
using GithubApiLib.Services.Interfaces;

namespace GithubApiLib.Services
{
    public class RequestGithubAPIService : IRequestGithubAPIService
    {
        public HttpRequestMessage GenerateRequest(HttpMethod method, Uri url)
        {
            HttpRequestMessage request = new(method, url);

            request.Headers.Add(nameof(HeaderConsts.Accept), HeaderConsts.Accept);
            request.Headers.Add(nameof(HeaderConsts.Authorization), HeaderConsts.Authorization);
            request.Headers.Add("User-Agent", HeaderConsts.UserAgent);
            request.Headers.Add("X-GitHub-Api-Version", "2022-11-28");
            request.Headers.Add("access-control-allow-origin", "*");

            return request;
        }
    }
}
