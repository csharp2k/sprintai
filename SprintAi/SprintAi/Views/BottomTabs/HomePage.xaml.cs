using SprintAi.Views;

namespace SprintAi.Views.BottomTabs;

public partial class HomePage : ContentPage
{
    public event EventHandler FollowingTapped;
    public event EventHandler ExploreTapped;
    public event EventHandler NearbyTapped;

    private FollowingPage _followingPage;
    private ExplorePage _explorePage;
    private NearbyPage _nearbyPage;

    public HomePage()
    {
        InitializeComponent();
    }

    public void InitializeInnerPages(object bindingContext)
    {
        _followingPage = new FollowingPage { BindingContext = bindingContext };
        _explorePage = new ExplorePage { BindingContext = bindingContext };
        _nearbyPage = new NearbyPage { BindingContext = bindingContext };

        // default
        ShowFollowing();
    }

    private void ShowFollowing()
    {
        InnerContentHolder.Content = _followingPage.Content;
    }

    private void ShowExplore()
    {
        InnerContentHolder.Content = _explorePage.Content;
    }

    private void ShowNearby()
    {
        InnerContentHolder.Content = _nearbyPage.Content;
    }

    // Public API to allow outer container to control which inner page is shown
    public void ShowFollowingInner() => ShowFollowing();
    public void ShowExploreInner() => ShowExplore();
    public void ShowNearbyInner() => ShowNearby();

    private void Following_Tapped(object sender, EventArgs e)
    {
        ShowFollowing();
        FollowingTapped?.Invoke(this, EventArgs.Empty);
    }

    private void Explore_Tapped(object sender, EventArgs e)
    {
        ShowExplore();
        ExploreTapped?.Invoke(this, EventArgs.Empty);
    }

    private void Nearby_Tapped(object sender, EventArgs e)
    {
        ShowNearby();
        NearbyTapped?.Invoke(this, EventArgs.Empty);
    }
}
