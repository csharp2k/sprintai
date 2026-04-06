using SprintAi.Views;

namespace SprintAi.Views.BottomTabs;

public partial class HomePage : ContentPage
{
    // unused events removed

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
        SetSelectedLabel(FollowingLabel);
    }

    private void ShowExplore()
    {
        InnerContentHolder.Content = _explorePage.Content;
        SetSelectedLabel(ExploreLabel);
    }

    private void ShowNearby()
    {
        InnerContentHolder.Content = _nearbyPage.Content;
        SetSelectedLabel(NearbyLabel);
    }

    // Public API to allow outer container to control which inner page is shown
    public void ShowFollowingInner() => ShowFollowing();
    public void ShowExploreInner() => ShowExplore();
    public void ShowNearbyInner() => ShowNearby();

    private void Following_Tapped(object sender, EventArgs e)
    {
        ShowFollowing();
    }

    private void Explore_Tapped(object sender, EventArgs e)
    {
        ShowExplore();
    }

    private void Nearby_Tapped(object sender, EventArgs e)
    {
        ShowNearby();
    }

    private void SetSelectedLabel(Label selected)
    {
        // default styles
        var defaultColor = Colors.Gray;

        FollowingLabel.TextColor = defaultColor;
        ExploreLabel.TextColor = defaultColor;
        NearbyLabel.TextColor = defaultColor;

        FollowingLabel.FontAttributes = FontAttributes.None;
        ExploreLabel.FontAttributes = FontAttributes.None;
        NearbyLabel.FontAttributes = FontAttributes.None;

        // highlight selected
        selected.TextColor = Colors.Black;
        selected.FontAttributes = FontAttributes.Bold;
    }
}
