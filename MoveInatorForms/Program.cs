using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoveInatorForms.Domains.Entities.Outros;
using MoveInatorForms.Forms;
using MoveInatorForms.Structures;
using GithubApiLib.Structures;

namespace MoveInatorForms
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static DatabaseJson DatabaseJson { get; private set; }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var builder = Host.CreateApplicationBuilder().Inject()
                                                         .InjectGithubApiLib();

            ServiceProvider = builder.Build().Services;
            DatabaseJson = new DatabaseJson();

            DatabaseJson.Load();
            Run();
        }

        static void Run()
        {
            var main = ServiceProvider.GetRequiredService<MainForm>();

            Application.Run(main);
        }
    }
}