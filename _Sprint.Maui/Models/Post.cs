namespace Sprint.Maui.Models;

public class Post
{
    public string Id { get; set; }
    public string AuthorId { get; set; }
    public string AuthorName { get; set; }
    public string AuthorAvatar { get; set; }
    public string Content { get; set; }
    public List<string> Images { get; set; } = new();
    public DateTime CreatedAt { get; set; }
    public int LikesCount { get; set; }
    public int CommentsCount { get; set; }
    public bool IsLiked { get; set; }
    public List<Comment> Comments { get; set; } = new();
}

public class Comment
{
    public string Id { get; set; }
    public string AuthorId { get; set; }
    public string AuthorName { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}