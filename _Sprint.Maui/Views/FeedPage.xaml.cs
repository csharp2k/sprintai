using Sprint.Maui.ViewModels;

namespace Sprint.Maui.Views;

public partial class FeedPage : ContentPage
{
    public FeedPage(FeedViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is FeedViewModel viewModel)
        {
            await viewModel.LoadPostsAsync();
        }
    }
}