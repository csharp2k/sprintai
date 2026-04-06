using Sprint.Maui.ViewModels;

namespace Sprint.Maui.Views;

public partial class MessagesPage : ContentPage
{
    public MessagesPage(MessagesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is MessagesViewModel viewModel)
        {
            await viewModel.LoadConversationsAsync();
        }
    }
}