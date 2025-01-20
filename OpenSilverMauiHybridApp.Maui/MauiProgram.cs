using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OpenSilver.MauiHybrid.Runner;

namespace OpenSilverMauiHybridApp.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("OpenSilverMauiHybridApp.Maui.appsettings.json");
            if (stream != null) builder.Configuration.AddJsonStream(stream);

            builder.Services.AddScoped<IMauiHybridRunner, MauiHybridRunner>();
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}