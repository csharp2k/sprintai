using Sprint.Maui.ViewModels;

namespace Sprint.Maui.Views;

public partial class CreatePostPage : ContentPage
{
    public CreatePostPage(CreatePostViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}