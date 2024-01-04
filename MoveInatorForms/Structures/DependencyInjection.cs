using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoveInatorForms.Forms;
using MoveInatorForms.Services;
using MoveInatorForms.Services.Interfaces;

namespace MoveInatorForms.Structures
{
    public static class DependencyInjection
    {
        public static HostApplicationBuilder Inject(this HostApplicationBuilder builder)
        {
            builder.Services.AddSingleton<ICSVService, CSVService>();

            builder.Services.AddTransient<MainForm>();

            return builder;
        }

        public static HostApplicationBuilder InjectContext(this HostApplicationBuilder builder, string connectionString)
        {
            builder.Services.AddDbContext<MoveInatorContext>(opt => opt.UseSqlServer(connectionString));

            return builder;
        }
    }
}
