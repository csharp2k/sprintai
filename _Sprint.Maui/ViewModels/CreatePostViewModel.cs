using Sprint.Maui.Services;
using CommunityToolkit.Mvvm.Input;

namespace Sprint.Maui.ViewModels;

public partial class CreatePostViewModel : BaseViewModel
{
    private readonly IPostService _postService;
    private readonly INavigationService _navigationService;

    private string _content;
    private List<string> _selectedImages = new();

    public string Content
    {
        get => _content;
        set => SetProperty(ref _content, value);
    }

    public List<string> SelectedImages
    {
        get => _selectedImages;
        set => SetProperty(ref _selectedImages, value);
    }

    public CreatePostViewModel(IPostService postService, INavigationService navigationService)
    {
        _postService = postService;
        _navigationService = navigationService;
        Title = "Create Post";
    }

    [RelayCommand]
    public async Task CreatePostAsync()
    {
        if (IsBusy) return;

        if (string.IsNullOrWhiteSpace(Content))
        {
            await Shell.Current.DisplayAlert("Error", "Please enter some content", "OK");
            return;
        }

        try
        {
            IsBusy = true;
            var success = await _postService.CreatePostAsync(Content, SelectedImages);

            if (success)
            {
                await Shell.Current.DisplayAlert("Success", "Post created successfully!", "OK");
                await _navigationService.GoBackAsync();
            }
            else
            {
                await Shell.Current.DisplayAlert("Error", "Failed to create post", "OK");
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
    public async Task AddImageAsync()
    {
        // TODO: Implement image picker
        await Shell.Current.DisplayAlert("Add Image", "Image picker coming soon!", "OK");
    }

    [RelayCommand]
    public async Task CancelAsync()
    {
        await _navigationService.GoBackAsync();
    }
}