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
            var builder = Host.CreateApplicationBuilder().Inject();

            var host = builder.Build();
            ServiceProvider = host.Services;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new LoginForm());
        }
    }
}