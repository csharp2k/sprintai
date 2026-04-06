namespace Sprint.Maui;

public partial class App : Microsoft.Maui.Controls.Application
{
    public App()
    {
        try
        {
            InitializeComponent();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in App constructor: {ex}");
            throw;
        }
    }

    protected override Microsoft.Maui.Controls.Window CreateWindow(IActivationState activationState)
    {
        try
        {
            Console.WriteLine("Creating window");
            var window = new Microsoft.Maui.Controls.Window(new AppShell());
            // window.Activate(); // Not available
            return window;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in CreateWindow: {ex}");
            throw;
        }
    }
}