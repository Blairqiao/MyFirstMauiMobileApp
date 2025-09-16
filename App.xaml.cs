using MyFirstMauiMobileApp.View;

namespace MyFirstMauiMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new MainPage();
        }
    }
}
