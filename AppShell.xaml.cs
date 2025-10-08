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
            //Layouts
            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));

            //Layouts Children
            Routing.RegisterRoute(nameof(LayoutsStackPage), typeof(LayoutsStackPage));
        }
    }
}
