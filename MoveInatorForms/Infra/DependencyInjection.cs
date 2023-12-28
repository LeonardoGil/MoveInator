using Microsoft.Extensions.Hosting;

namespace MoveInatorForms.Infra
{
    public static class DependencyInjection
    {
        public static HostApplicationBuilder Inject(this HostApplicationBuilder builder)
        {
            return builder;
        }
    }
}
