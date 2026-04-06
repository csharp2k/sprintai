using Sprint.Maui.Services;
using CommunityToolkit.Mvvm.Input;

namespace Sprint.Maui.ViewModels;

public partial class LoginViewModel : BaseViewModel
{
    private readonly IAuthService _authService;
    private readonly INavigationService _navigationService;

    private string _email;
    private string _password;

    public string Email
    {
        get => _email;
        set => SetProperty(ref _email, value);
    }

    public string Password
    {
        get => _password;
        set => SetProperty(ref _password, value);
    }

    public LoginViewModel(IAuthService authService, INavigationService navigationService)
    {
        _authService = authService;
        _navigationService = navigationService;
        Title = "Login";
    }

    [RelayCommand]
    public async Task LoginAsync()
    {
        if (IsBusy) return;

        if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
        {
            await Shell.Current.DisplayAlert("Error", "Please enter email and password", "OK");
            return;
        }

        try
        {
            IsBusy = true;
            var success = await _authService.LoginAsync(Email, Password);

            if (success)
            {
                await _navigationService.NavigateToAsync("//FeedPage");
            }
            else
            {
                await Shell.Current.DisplayAlert("Error", "Invalid credentials", "OK");
            }
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }

    [RelayCommand]
    public async Task RegisterAsync()
    {
        // TODO: Navigate to register page
        await Shell.Current.DisplayAlert("Register", "Registration feature coming soon!", "OK");
    }
}