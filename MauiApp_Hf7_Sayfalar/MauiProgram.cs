using MauiApp_Hf7_Sayfalar.ViewModel;

using Microsoft.Extensions.Logging;

using System.Security.Cryptography.X509Certificates;

namespace MauiApp_Hf7_Sayfalar
{
    public static class MauiProgram
    {
        public static KisiViewModel kisiViewModel = new KisiViewModel();

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            

            return builder.Build();
        }
    }
}
