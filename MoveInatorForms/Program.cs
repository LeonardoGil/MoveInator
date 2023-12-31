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

            var builder = Host.CreateApplicationBuilder().Inject();

            //Login(builder);

            ServiceProvider = builder.Build().Services;

            Run();
        }

        static void Run()
        {
            var main = ServiceProvider.GetRequiredService<MainForm>();

            Application.Run(main);
        }

        static void Login(HostApplicationBuilder builder)
        {
            var login = new LoginForm();

            Application.Run(login);

            if (login.OfflineMode)
                return;

            builder.InjectContext(login.ConnectionString);
        }
    }
}