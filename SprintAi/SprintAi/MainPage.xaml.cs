using SprintAi.ViewModels;
using Microsoft.Maui.Graphics;
using SprintAi.Views.BottomTabs;

namespace SprintAi
{
    public partial class MainPage : ContentPage
    {
        // category pages moved into HomePage

        private HomePage _homePage;
        private ContentPage _marketPage;
        private ContentPage _messagesPage;
        private ContentPage _mePage;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

            // category pages are handled from HomePage now

            _homePage = new HomePage { BindingContext = BindingContext };
            _homePage.InitializeInnerPages(BindingContext);

            _marketPage = new MarketPage { BindingContext = BindingContext };
            _messagesPage = new MessagesPage { BindingContext = BindingContext };
            _mePage = new MePage { BindingContext = BindingContext };

            // Show Home by default
            ContentHolder.Content = _homePage.Content;

            // then instruct HomePage to show Explore inner page
            _homePage.ShowExploreInner();

            // Ensure the bottom nav highlights the Home item by default
            UpdateSelectedLabel(HomeLabel);
        }

        // Local methods for switching to removed standalone category pages were removed

        // top navigation is handled by HomePage events; category taps moved into HomePage

        private void OnHomeTapped(object sender, EventArgs e)
        {
            // Home should show the home page which contains the category bar and default feed
            ContentHolder.Content = _homePage.Content;
            UpdateSelectedLabel(HomeLabel);
        }

        private void OnMarketTapped(object sender, EventArgs e)
        {
            ContentHolder.Content = _marketPage.Content;
            UpdateSelectedLabel(MarketLabel);
        }

        private void OnMessagesTapped(object sender, EventArgs e)
        {
            ContentHolder.Content = _messagesPage.Content;
            UpdateSelectedLabel(MessagesLabel);
        }

        private void OnMeTapped(object sender, EventArgs e)
        {
            ContentHolder.Content = _mePage.Content;
            UpdateSelectedLabel(MeLabel);
        }

        private void UpdateSelectedLabel(Label selected)
        {
            // Reset all to default (Gray, normal)
            HomeLabel.TextColor = Colors.Gray;
            HomeLabel.FontAttributes = FontAttributes.None;

            MarketLabel.TextColor = Colors.Gray;
            MarketLabel.FontAttributes = FontAttributes.None;

            MessagesLabel.TextColor = Colors.Gray;
            MessagesLabel.FontAttributes = FontAttributes.None;

            MeLabel.TextColor = Colors.Gray;
            MeLabel.FontAttributes = FontAttributes.None;

            // Highlight the selected one (Black, Bold)
            if (selected != null)
            {
                selected.TextColor = Colors.Black;
                selected.FontAttributes = FontAttributes.Bold;
            }
        }
    }
}
