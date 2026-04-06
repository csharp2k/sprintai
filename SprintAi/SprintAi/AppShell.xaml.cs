namespace SprintAi
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register routes for category pages
            Routing.RegisterRoute("about", typeof(Views.AboutPage));
        }
    }
}
