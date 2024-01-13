using GithubApiLib.Domains.Entities;

namespace GithubApiLib.Services.Interfaces
{
    public interface IReleaseService
    {
        Task<List<Release>> ListReleasesAsync();
        Task<Release> LastReleaseAsync();
    }
}
