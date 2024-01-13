using GithubApiLib.Domains.Entities;

namespace MoveInatorForms.Services.Interfaces
{
    public interface IUpdateService
    {
        Release LastRelease { get; }

        List<Release> Releases { get; }

        bool Updated();

        string GetLastVersion();
    }
}
