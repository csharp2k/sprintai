using SprintAi.ViewModels;
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
        }

        // Local methods for switching to removed standalone category pages were removed

        // top navigation is handled by HomePage events; category taps moved into HomePage

        private void OnHomeTapped(object sender, EventArgs e)
        {
            // Home should show the home page which contains the category bar and default feed
            ContentHolder.Content = _homePage.Content;
        }

        private void OnMarketTapped(object sender, EventArgs e)
        {
            ContentHolder.Content = _marketPage.Content;
        }

        private void OnMessagesTapped(object sender, EventArgs e)
        {
            ContentHolder.Content = _messagesPage.Content;
        }

        private void OnMeTapped(object sender, EventArgs e)
        {
            ContentHolder.Content = _mePage.Content;
        }
    }
}
