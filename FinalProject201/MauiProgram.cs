using Microsoft.Extensions.Logging;

namespace FinalProject201
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Geom-SemiBold.ttf", "GeomSemibold");
                    fonts.AddFont("Geom-Regular.ttf", "GeomRegular");
                });

            //builder.Services.AddSingleton<OrderServices>();
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
