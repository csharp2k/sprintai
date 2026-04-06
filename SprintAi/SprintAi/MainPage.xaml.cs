using SprintAi.ViewModels;
using SprintAi.Views;
using SprintAi.Views.BottomTabs;

namespace SprintAi
{
    public partial class MainPage : ContentPage
    {
        private ContentPage _followingPage;
        private ContentPage _explorePage;
        private ContentPage _nearbyPage;

        // category pages removed from MainPage (moved into HomePage)

        private HomePage _homePage;
        private ContentPage _marketPage;
        private ContentPage _messagesPage;
        private ContentPage _mePage;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();

            // Initialize pages but do not push them
            _followingPage = new FollowingPage { BindingContext = BindingContext };
            _explorePage = new ExplorePage { BindingContext = BindingContext };
            _nearbyPage = new NearbyPage { BindingContext = BindingContext };

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

        private void ShowFollowing()
        {
            ContentHolder.Content = _followingPage.Content;
        }

        private void ShowExplore()
        {
            ContentHolder.Content = _explorePage.Content;
        }

        private void ShowNearby()
        {
            ContentHolder.Content = _nearbyPage.Content;
        }

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
