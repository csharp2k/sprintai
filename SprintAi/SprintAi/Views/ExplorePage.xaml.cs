using SprintAi.ViewModels;
using SprintAi.Views.Categories;

namespace SprintAi.Views;

public partial class ExplorePage : ContentPage
{
    public ExplorePage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
        // Set initial category content
        CategoryContent.Content = new ForYouPage().Content;
        SetSelectedLabel(ForYouLabel);
    }

    private async void OnForYouTapped(object sender, EventArgs e)
    {
        // Load the ForYouPage content into the host ContentView so the category bar remains visible
        CategoryContent.Content = new ForYouPage().Content;
        SetSelectedLabel(ForYouLabel);
    }

    private async void OnVideoTapped(object sender, EventArgs e)
    {
        CategoryContent.Content = new VideoPage().Content;
        SetSelectedLabel(VideoLabel);
    }

    private async void OnLiveTapped(object sender, EventArgs e)
    {
        CategoryContent.Content = new LivePage().Content;
        SetSelectedLabel(LiveLabel);
    }

    private async void OnSeriesTapped(object sender, EventArgs e)
    {
        CategoryContent.Content = new SeriesPage().Content;
        SetSelectedLabel(SeriesLabel);
    }

    private async void OnFashionTapped(object sender, EventArgs e)
    {
        CategoryContent.Content = new FashionPage().Content;
        SetSelectedLabel(FashionLabel);
    }

    private void SetSelectedLabel(Label selected)
    {
        // reset all
        var defaultColor = Colors.Black;
        ForYouLabel.TextColor = defaultColor;
        VideoLabel.TextColor = defaultColor;
        LiveLabel.TextColor = defaultColor;
        SeriesLabel.TextColor = defaultColor;
        FashionLabel.TextColor = defaultColor;

        ForYouLabel.FontAttributes = FontAttributes.None;
        VideoLabel.FontAttributes = FontAttributes.None;
        LiveLabel.FontAttributes = FontAttributes.None;
        SeriesLabel.FontAttributes = FontAttributes.None;
        FashionLabel.FontAttributes = FontAttributes.None;

        // highlight selected
        selected.TextColor = Colors.Black;
        selected.FontAttributes = FontAttributes.Bold;
    }
}
