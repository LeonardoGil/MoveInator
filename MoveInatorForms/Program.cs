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
            ConfigureApplication();
            LoadDependencies();
            RunApplication();
        }

        static void LoadDependencies()
        {
            var builder = Host.CreateApplicationBuilder().Inject()
                                                         .InjectGithubApiLib();

            ServiceProvider = builder.Build().Services;
            DatabaseJson = new DatabaseJson();

            DatabaseJson.Load();
        }

        static void ConfigureApplication()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // Não vejo necessidade de configurar a inicialização no csproj...
            // ApplicationConfiguration.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        static void RunApplication()
        {
            var main = ServiceProvider.GetRequiredService<MainForm>();

            Application.Run(main);
        }
    }
}