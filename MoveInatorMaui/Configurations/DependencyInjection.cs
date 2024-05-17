using MoveInatorMaui.Pages.Cadastros;

namespace MoveInatorMaui.Configurations
{
    public static class DependencyInjection
    {
        public static MauiAppBuilder InjectPages(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<App>();
            builder.Services.AddSingleton<AppShell>();
            
            builder.Services.AddSingleton<CadastroEmpresaPage>();

            return builder;
        }
    }
}
