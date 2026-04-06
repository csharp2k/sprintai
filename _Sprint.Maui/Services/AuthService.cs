using Sprint.Maui.Models;

namespace Sprint.Maui.Services;

public interface IAuthService
{
    Task<bool> LoginAsync(string email, string password);
    Task<bool> RegisterAsync(string email, string password, string username);
    Task LogoutAsync();
    bool IsAuthenticated { get; }
    User CurrentUser { get; }
}

public class AuthService : IAuthService
{
    public User CurrentUser { get; private set; }
    public bool IsAuthenticated => CurrentUser != null;

    public async Task<bool> LoginAsync(string email, string password)
    {
        // TODO: Implement actual authentication
        // For now, simulate login
        await Task.Delay(1000);

        if (email == "test@test.com" && password == "password")
        {
            CurrentUser = new User
            {
                Id = "1",
                Email = email,
                Username = "testuser",
                DisplayName = "Test User",
                Bio = "Hello, I'm a test user!",
                FollowersCount = 150,
                FollowingCount = 75,
                PostsCount = 25,
                IsVerified = false
            };
            return true;
        }

        return false;
    }

    public async Task<bool> RegisterAsync(string email, string password, string username)
    {
        // TODO: Implement actual registration
        await Task.Delay(1000);
        return true;
    }

    public async Task LogoutAsync()
    {
        await Task.Delay(500);
        CurrentUser = null;
    }
}