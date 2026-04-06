using SprintAi.ViewModels;

namespace SprintAi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private async void OnFollowingTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//following");
        }

        private async void OnExploreTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//explore");
        }

        private async void OnNearbyTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//nearby");
        }

        // Removed unused overload to avoid ambiguity with the tapped handlers in XAML.
    }
}
