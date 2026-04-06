namespace SprintAi
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // Register routes for category pages
            Routing.RegisterRoute("ForYouPage", typeof(Views.Categories.ForYouPage));
            Routing.RegisterRoute("VideoPage", typeof(Views.Categories.VideoPage));
            Routing.RegisterRoute("LivePage", typeof(Views.Categories.LivePage));
            Routing.RegisterRoute("SeriesPage", typeof(Views.Categories.SeriesPage));
            Routing.RegisterRoute("FashionPage", typeof(Views.Categories.FashionPage));
        }
    }
}
