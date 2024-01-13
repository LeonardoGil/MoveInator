namespace GithubApiLib.Services.Interfaces
{
    public interface IRequestGithubAPIService
    {
        HttpRequestMessage GenerateRequest(HttpMethod method, Uri url);
    }
}
