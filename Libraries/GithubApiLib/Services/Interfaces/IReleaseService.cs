using GithubApiLib.Domains.Entities;

namespace GithubApiLib.Services.Interfaces
{
    public interface IReleaseService
    {
        List<Release> ListReleases();
    }
}
