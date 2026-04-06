using Sprint.Maui.Models;
using Sprint.Maui.Services;
using CommunityToolkit.Mvvm.Input;

namespace Sprint.Maui.ViewModels;

public partial class ProfileViewModel : BaseViewModel
{
    private readonly IAuthService _authService;
    private readonly INavigationService _navigationService;

    public User CurrentUser => _authService.CurrentUser;

    public ProfileViewModel(IAuthService authService, INavigationService navigationService)
    {
        _authService = authService;
        _navigationService = navigationService;
        Title = "Profile";
    }

    [RelayCommand]
    public async Task LogoutAsync()
    {
        bool confirm = await Shell.Current.DisplayAlert(
            "Logout",
            "Are you sure you want to logout?",
            "Yes",
            "No");

        if (confirm)
        {
            await _authService.LogoutAsync();
            await _navigationService.NavigateToAsync("LoginPage");
        }
    }

    [RelayCommand]
    public async Task EditProfileAsync()
    {
        // TODO: Navigate to edit profile page
        await Shell.Current.DisplayAlert("Edit Profile", "Edit profile feature coming soon!", "OK");
    }

    [RelayCommand]
    public async Task ViewSettingsAsync()
    {
        // TODO: Navigate to settings page
        await Shell.Current.DisplayAlert("Settings", "Settings feature coming soon!", "OK");
    }
}