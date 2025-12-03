using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using MyFirstMauiMobileApp.View;
using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                   .UseMauiCommunityToolkit()
                   .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
#if DEBUG
            builder.Logging.AddDebug();
#endif

            try
            {
                builder.Services.AddSingleton<CollectionsButtonPage>();
                builder.Services.AddSingleton<CollectionsButtonViewModel>();
            }
            catch (Exception ex)
            {

            }

            return builder.Build();
        }
    }
}