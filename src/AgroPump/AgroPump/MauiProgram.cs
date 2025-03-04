using Microsoft.Extensions.Logging;

namespace AgroPump;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("fa-solid-900.ttf", "Font Awesome 6 Free Solid");
                fonts.AddFont("Inter_24pt-Regular.ttf", "InterRegular");
                fonts.AddFont("Inter_24pt-Bold.ttf", "InterBold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}