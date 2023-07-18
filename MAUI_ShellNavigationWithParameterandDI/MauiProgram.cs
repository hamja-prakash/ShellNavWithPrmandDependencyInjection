using CommunityToolkit.Maui;
using MAUI_ShellNavigationWithParameterandDI.Services;
using MAUI_ShellNavigationWithParameterandDI.ViewModels;
using Microsoft.Extensions.Logging;

namespace MAUI_ShellNavigationWithParameterandDI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<IStudentService, StudentService>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<StudentListViewModel>();

        builder.Services.AddSingleton<StudentDetailsView>();
        builder.Services.AddSingleton<StudentDetailsViewModel>();
        
#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
