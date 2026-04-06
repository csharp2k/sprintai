using System.Collections.ObjectModel;
using SprintAi.Models;

namespace SprintAi.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Post> Posts { get; set; }

        public MainViewModel()
        {
            Posts = new ObservableCollection<Post>
            {
                new Post { ImageUrl = "https://via.placeholder.com/300x200", Title = "Sample Post 1", AuthorAvatar = "https://via.placeholder.com/50", AuthorName = "User1", Likes = "123" },
                new Post { ImageUrl = "https://via.placeholder.com/300x250", Title = "Sample Post 2", AuthorAvatar = "https://via.placeholder.com/50", AuthorName = "User2", Likes = "456" },
                new Post { ImageUrl = "https://via.placeholder.com/300x180", Title = "Sample Post 3", AuthorAvatar = "https://via.placeholder.com/50", AuthorName = "User3", Likes = "789" },
                new Post { ImageUrl = "https://via.placeholder.com/320x200", Title = "Sample Post 4", AuthorAvatar = "https://via.placeholder.com/50", AuthorName = "User4", Likes = "42" },
                new Post { ImageUrl = "https://via.placeholder.com/300x220", Title = "Sample Post 5", AuthorAvatar = "https://via.placeholder.com/50", AuthorName = "User5", Likes = "87" },
                new Post { ImageUrl = "https://via.placeholder.com/400x250", Title = "Sample Post 6", AuthorAvatar = "https://via.placeholder.com/50", AuthorName = "User6", Likes = "301" },
                new Post { ImageUrl = "https://via.placeholder.com/360x200", Title = "Sample Post 7", AuthorAvatar = "https://via.placeholder.com/50", AuthorName = "User7", Likes = "19" },
                new Post { ImageUrl = "https://via.placeholder.com/300x300", Title = "Sample Post 8", AuthorAvatar = "https://via.placeholder.com/50", AuthorName = "User8", Likes = "204" },
                new Post { ImageUrl = "https://via.placeholder.com/280x180", Title = "Sample Post 9", AuthorAvatar = "https://via.placeholder.com/50", AuthorName = "User9", Likes = "76" },
                new Post { ImageUrl = "https://via.placeholder.com/330x190", Title = "Sample Post 10", AuthorAvatar = "https://via.placeholder.com/50", AuthorName = "User10", Likes = "12" },
                new Post { ImageUrl = "https://via.placeholder.com/350x210", Title = "Sample Post 11", AuthorAvatar = "https://via.placeholder.com/50", AuthorName = "User11", Likes = "999" },
                new Post { ImageUrl = "https://via.placeholder.com/310x230", Title = "Sample Post 12", AuthorAvatar = "https://via.placeholder.com/50", AuthorName = "User12", Likes = "5" },
                new Post { ImageUrl = "https://via.placeholder.com/300x240", Title = "Sample Post 13", AuthorAvatar = "https://via.placeholder.com/50", AuthorName = "User13", Likes = "67" },
            };
        }
    }
}