using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoveInatorForms.Forms;
using MoveInatorForms.Forms.Views;
using MoveInatorForms.Services;
using MoveInatorForms.Services.Interfaces;

namespace MoveInatorForms.Structures
{
    public static class DependencyInjection
    {
        public static HostApplicationBuilder Inject(this HostApplicationBuilder builder)
        {
            return builder.InjectServices()
                          .InjectForms();
        }

        public static HostApplicationBuilder InjectContext(this HostApplicationBuilder builder, string connectionString)
        {
            builder.Services.AddDbContext<MoveInatorContext>(opt => opt.UseSqlServer(connectionString));

            return builder;
        }

        private static HostApplicationBuilder InjectForms(this HostApplicationBuilder builder)
        {
            builder.Services.AddTransient<MainForm>();

            builder.Services.AddTransient<GerarCSVSimplesViewControl>();
            builder.Services.AddTransient<GerarMDFeSimplesViewControl>();
            builder.Services.AddTransient<CadastrosViewControl>();
            builder.Services.AddTransient<InicioViewControl>();
            builder.Services.AddTransient<NovidadesViewControl>();

            return builder;
        }

        private static HostApplicationBuilder InjectServices(this HostApplicationBuilder builder)
        {
            builder.Services.AddSingleton<ICSVService, CSVService>();
            builder.Services.AddSingleton<IMDFeService, MDFeService>();
            builder.Services.AddSingleton<IFileService, FileService>();
            builder.Services.AddSingleton<IUpdateService, UpdateService>();

            return builder;
        }
    }
}
