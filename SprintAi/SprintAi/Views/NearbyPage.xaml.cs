using SprintAi.ViewModels;

namespace SprintAi.Views;

public partial class NearbyPage : ContentPage
{
    public NearbyPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}
