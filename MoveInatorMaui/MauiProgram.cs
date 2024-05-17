using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MoveInatorMaui.Configurations;

namespace MoveInatorMaui
{
    public static class MauiProgram
    {
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
//    		builder.Logging.AddDebug();
//#endif

            return builder.Build();
        }
    }
}
