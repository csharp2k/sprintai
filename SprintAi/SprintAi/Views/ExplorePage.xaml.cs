using SprintAi.ViewModels;

namespace SprintAi.Views;

public partial class ExplorePage : ContentPage
{
    public ExplorePage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}
