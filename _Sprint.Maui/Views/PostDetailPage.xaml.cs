using Sprint.Maui.ViewModels;

namespace Sprint.Maui.Views;

public partial class PostDetailPage : ContentPage
{
    public PostDetailPage(PostDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}