using Microsoft.Extensions.Logging;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Hosting;
using Sprint.Maui.Services;
using Sprint.Maui.ViewModels;
using Sprint.Maui.Views;

namespace Sprint.Maui;

public static class MauiProgram
{
    [STAThread]
    public static void Main()
    {
        var logFile = "C:\\Temp\\sprint_maui_debug.log";
        try
        {
            System.IO.File.AppendAllText(logFile, $"[{DateTime.Now:HH:mm:ss}] Main started\n");
            
            System.IO.File.AppendAllText(logFile, $"[{DateTime.Now:HH:mm:ss}] Creating MAUI app\n");
            var mauiApp = CreateMauiApp().Build();
            
            System.IO.File.AppendAllText(logFile, $"[{DateTime.Now:HH:mm:ss}] MAUI app built\n");
            
            var autoResetEvent = new System.Threading.AutoResetEvent(false);
            System.IO.File.AppendAllText(logFile, $"[{DateTime.Now:HH:mm:ss}] Waiting on event\n");
            
            // Keep the app alive indefinitely
            autoResetEvent.WaitOne();
            
            System.IO.File.AppendAllText(logFile, $"[{DateTime.Now:HH:mm:ss}] Event was set (shouldn't happen)\n");
        }
        catch (Exception ex)
        {
            System.IO.File.AppendAllText(logFile, $"[{DateTime.Now:HH:mm:ss}] Exception: {ex}\n");
            Console.WriteLine($"Error: {ex}");
            System.Diagnostics.Debug.WriteLine($"Error: {ex}");
        }
        finally
        {
            System.IO.File.AppendAllText(logFile, $"[{DateTime.Now:HH:mm:ss}] Main exited\n");
        }
    }

    [System.Runtime.InteropServices.DllImport("ole32.dll")]
    private static extern int CoInitializeEx(IntPtr pReserved, uint dwCoInit);

    private const uint COINIT_MULTITHREADED = 0;
    private const uint COINIT_APARTMENTTHREADED = 2;

    public static MauiAppBuilder CreateMauiApp()
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

        // Register Services
        builder.Services.AddSingleton<INavigationService, NavigationService>();
        builder.Services.AddSingleton<IAuthService, AuthService>();
        builder.Services.AddSingleton<IPostService, PostService>();
        builder.Services.AddSingleton<IMessageService, MessageService>();

        // Register ViewModels
        builder.Services.AddTransient<LoginViewModel>();
        builder.Services.AddTransient<FeedViewModel>();
        builder.Services.AddTransient<MessagesViewModel>();
        builder.Services.AddTransient<ProfileViewModel>();
        builder.Services.AddTransient<PostDetailViewModel>();
        builder.Services.AddTransient<CreatePostViewModel>();

        // Register Views
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<FeedPage>();
        builder.Services.AddTransient<MessagesPage>();
        builder.Services.AddTransient<ProfilePage>();
        builder.Services.AddTransient<PostDetailPage>();
        builder.Services.AddTransient<CreatePostPage>();

        return builder;
    }
}