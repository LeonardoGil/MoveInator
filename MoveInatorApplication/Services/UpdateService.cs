using GithubApiLib.Domains.Entities;
using GithubApiLib.Services.Interfaces;
using MoveInatorApplication.Services.Interfaces;
using System.Reflection;

namespace MoveInatorForms.Services
{
    public class UpdateService : IUpdateService
    {
        private readonly IReleaseService releaseService;

        private Release _lastRelease;
        private List<Release> _releases;

        public Release LastRelease
        {
            get
            {
                _lastRelease ??= releaseService.LastReleaseAsync().Result;
                return _lastRelease;
            }
        }

        public List<Release> Releases
        {
            get
            {
                _releases ??= releaseService.ListReleasesAsync().Result;
                return _releases;
            }
        }

        public UpdateService(IReleaseService releaseService)
        {
            this.releaseService = releaseService;
        }

        public bool Updated()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            var lastReleaseVersion = LastRelease.Tag.Replace("Pre-Release@", string.Empty);

            return version == lastReleaseVersion;
        }

        public string GetLastVersion()
        {
            return LastRelease.Tag.Replace("Pre-Release@", string.Empty);
        }
    }
}
