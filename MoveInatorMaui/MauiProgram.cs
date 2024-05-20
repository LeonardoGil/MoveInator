using CommunityToolkit.Maui;
using MoveInatorDomain.Entities.Outros;
using MoveInatorMaui.Configurations;

namespace MoveInatorMaui
{
    public static class MauiProgram
    {
        public static DatabaseJson DatabaseJson { get; private set; }

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.UseMauiApp<App>()
                   .UseMauiCommunityToolkit()
                   .InjectPages()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                   });

            //#if DEBUG
            //            builder.Logging.SetMinimumLevel(LogLevel.Trace);
            //            builder.Logging.AddDebug();
            //#endif

            DatabaseJson = new DatabaseJson();
            DatabaseJson.Load();

            return builder.Build();
        }
    }
}
