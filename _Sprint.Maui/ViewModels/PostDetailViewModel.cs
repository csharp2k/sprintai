using Sprint.Maui.Models;
using Sprint.Maui.Services;
using CommunityToolkit.Mvvm.Input;

namespace Sprint.Maui.ViewModels;

[QueryProperty(nameof(PostId), nameof(PostId))]
public partial class PostDetailViewModel : BaseViewModel
{
    private readonly IPostService _postService;
    private readonly INavigationService _navigationService;

    private string _postId;
    private Post _post;

    public string PostId
    {
        get => _postId;
        set
        {
            _postId = value;
            Task.Run(() => LoadPostAsync());
        }
    }

    public Post Post
    {
        get => _post;
        set => SetProperty(ref _post, value);
    }

    public PostDetailViewModel(IPostService postService, INavigationService navigationService)
    {
        _postService = postService;
        _navigationService = navigationService;
        Title = "Post";
    }

    [RelayCommand]
    public async Task LoadPostAsync()
    {
        if (IsBusy || string.IsNullOrEmpty(PostId)) return;

        try
        {
            IsBusy = true;
            var post = await _postService.GetPostAsync(PostId);
            Post = post;
            Title = $"Post by {post?.AuthorName}";
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
    public async Task LikePostAsync()
    {
        if (Post == null) return;

        try
        {
            bool success;
            if (Post.IsLiked)
            {
                success = await _postService.UnlikePostAsync(Post.Id);
                if (success)
                {
                    Post.IsLiked = false;
                    Post.LikesCount--;
                }
            }
            else
            {
                success = await _postService.LikePostAsync(Post.Id);
                if (success)
                {
                    Post.IsLiked = true;
                    Post.LikesCount++;
                }
            }
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
    }

    [RelayCommand]
    public async Task AddCommentAsync()
    {
        // TODO: Show comment input dialog
        await Shell.Current.DisplayAlert("Comment", "Comment feature coming soon!", "OK");
    }
}