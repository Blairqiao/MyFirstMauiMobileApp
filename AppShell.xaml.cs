using MyFirstMauiMobileApp.View;

namespace MyFirstMauiMobileApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRouting();
        }

        public void RegisterRouting()
        {
            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));
        }
    }
}
