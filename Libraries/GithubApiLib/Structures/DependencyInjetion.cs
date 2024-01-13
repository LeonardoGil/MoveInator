using GithubApiLib.Services;
using GithubApiLib.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GithubApiLib.Structures
{
    public static class DependencyInjetion
    {
        public static HostApplicationBuilder InjectGithubApiLib(this HostApplicationBuilder builder)
        {
            builder.Services.AddSingleton<IRequestGithubAPIService, RequestGithubAPIService>();
            builder.Services.AddSingleton<IReleaseService, ReleaseService>();

            return builder;
        }
    }
}
