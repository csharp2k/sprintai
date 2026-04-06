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
                // Add more dummy data as needed
            };
        }
    }
}