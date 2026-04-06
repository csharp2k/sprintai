using Sprint.Maui.Models;

namespace Sprint.Maui.Services;

public interface INavigationService
{
    Task NavigateToAsync(string route);
    Task GoBackAsync();
}

public class NavigationService : INavigationService
{
    public async Task NavigateToAsync(string route)
    {
        await Shell.Current.GoToAsync(route);
    }

    public async Task GoBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }
}