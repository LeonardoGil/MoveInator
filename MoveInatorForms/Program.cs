using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoveInatorForms.Forms;
using MoveInatorForms.Infra;

namespace MoveInatorForms
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Run();
        }

        static void Run()
        {
            var login = new LoginForm();

            Application.Run(login);

            if (login.Exit) return;

            CreateHost(login.ConnectionString);

            var main = ServiceProvider.GetRequiredService<MainForm>();

            Application.Run(main);
        }

        static void CreateHost(string connectionString)
        {
            var host = Host.CreateApplicationBuilder()
                           .Inject()
                           .InjectContext(connectionString)
                           .Build();

            ServiceProvider = host.Services;
        }
    }
}