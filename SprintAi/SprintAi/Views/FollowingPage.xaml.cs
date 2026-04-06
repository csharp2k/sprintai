using SprintAi.ViewModels;

namespace SprintAi.Views;

public partial class FollowingPage : ContentPage
{
    public FollowingPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}
