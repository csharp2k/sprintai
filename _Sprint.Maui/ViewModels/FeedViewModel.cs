using System.Collections.ObjectModel;
using Sprint.Maui.Models;
using Sprint.Maui.Services;
using CommunityToolkit.Mvvm.Input;

namespace Sprint.Maui.ViewModels;

public partial class FeedViewModel : BaseViewModel
{
    private readonly IPostService _postService;
    private readonly INavigationService _navigationService;

    public ObservableCollection<Post> Posts { get; } = new();

    public FeedViewModel(IPostService postService, INavigationService navigationService)
    {
        _postService = postService;
        _navigationService = navigationService;
        Title = "Feed";
    }

    [RelayCommand]
    public async Task LoadPostsAsync()
    {
        Console.WriteLine("Loading posts");
        if (IsBusy) return;

        try
        {
            IsBusy = true;
            var posts = await _postService.GetFeedAsync();
            Console.WriteLine($"Loaded {posts.Count} posts");
            Posts.Clear();
            foreach (var post in posts)
            {
                Posts.Add(post);
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
    public async Task LikePostAsync(Post post)
    {
        try
        {
            bool success;
            if (post.IsLiked)
            {
                success = await _postService.UnlikePostAsync(post.Id);
                if (success)
                {
                    post.IsLiked = false;
                    post.LikesCount--;
                }
            }
            else
            {
                success = await _postService.LikePostAsync(post.Id);
                if (success)
                {
                    post.IsLiked = true;
                    post.LikesCount++;
                }
            }
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
    }

    [RelayCommand]
    public async Task OpenPostAsync(Post post)
    {
        await _navigationService.NavigateToAsync($"PostDetailPage?postId={post.Id}");
    }

    [RelayCommand]
    public async Task CreatePostAsync()
    {
        await _navigationService.NavigateToAsync("CreatePostPage");
    }
}