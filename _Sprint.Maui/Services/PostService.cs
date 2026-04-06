using Sprint.Maui.Models;

namespace Sprint.Maui.Services;

public interface IPostService
{
    Task<List<Post>> GetFeedAsync();
    Task<Post> GetPostAsync(string postId);
    Task<bool> CreatePostAsync(string content, List<string> images = null);
    Task<bool> LikePostAsync(string postId);
    Task<bool> UnlikePostAsync(string postId);
    Task<List<Comment>> GetCommentsAsync(string postId);
    Task<bool> AddCommentAsync(string postId, string content);
}

public class PostService : IPostService
{
    public async Task<List<Post>> GetFeedAsync()
    {
        // TODO: Implement actual API call
        await Task.Delay(1000);

        return new List<Post>
        {
            new Post
            {
                Id = "1",
                AuthorId = "1",
                AuthorName = "John Doe",
                AuthorAvatar = null,
                Content = "Just finished an amazing project! 🚀 #coding #success",
                CreatedAt = DateTime.Now.AddHours(-2),
                LikesCount = 24,
                CommentsCount = 5,
                IsLiked = false
            },
            new Post
            {
                Id = "2",
                AuthorId = "2",
                AuthorName = "Jane Smith",
                AuthorAvatar = null,
                Content = "Beautiful sunset today! 🌅 Sometimes you just need to take a moment and appreciate the little things in life.",
                CreatedAt = DateTime.Now.AddHours(-4),
                LikesCount = 67,
                CommentsCount = 12,
                IsLiked = true
            }
        };
    }

    public async Task<Post> GetPostAsync(string postId)
    {
        var posts = await GetFeedAsync();
        return posts.FirstOrDefault(p => p.Id == postId);
    }

    public async Task<bool> CreatePostAsync(string content, List<string> images = null)
    {
        // TODO: Implement actual API call
        await Task.Delay(1000);
        return true;
    }

    public async Task<bool> LikePostAsync(string postId)
    {
        // TODO: Implement actual API call
        await Task.Delay(500);
        return true;
    }

    public async Task<bool> UnlikePostAsync(string postId)
    {
        // TODO: Implement actual API call
        await Task.Delay(500);
        return true;
    }

    public async Task<List<Comment>> GetCommentsAsync(string postId)
    {
        // TODO: Implement actual API call
        await Task.Delay(500);

        return new List<Comment>
        {
            new Comment
            {
                Id = "1",
                AuthorId = "3",
                AuthorName = "Bob Wilson",
                Content = "Congratulations! That's awesome!",
                CreatedAt = DateTime.Now.AddHours(-1)
            }
        };
    }

    public async Task<bool> AddCommentAsync(string postId, string content)
    {
        // TODO: Implement actual API call
        await Task.Delay(500);
        return true;
    }
}