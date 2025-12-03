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
            Routing.RegisterRoute(nameof(LayoutsVerticalStackPage), typeof(LayoutsVerticalStackPage));
            Routing.RegisterRoute(nameof(LayoutsHorizontalStackPage), typeof(LayoutsHorizontalStackPage));
            Routing.RegisterRoute(nameof(LayoutsAbsolutePage), typeof(LayoutsAbsolutePage));
            Routing.RegisterRoute(nameof(LayoutsFlexPage), typeof(LayoutsFlexPage));

            //Images
            Routing.RegisterRoute(nameof(ImagesPage), typeof(ImagesPage));

            //Images Children
            Routing.RegisterRoute(nameof(ImagesURIPage), typeof(ImagesURIPage));
            Routing.RegisterRoute(nameof(ImagesEmbeddedPage), typeof(ImagesEmbeddedPage));
            Routing.RegisterRoute(nameof(ImagesActivityIndicatorPage), typeof(ImagesActivityIndicatorPage));

            //Collections
            Routing.RegisterRoute(nameof(CollectionsMenuPage), typeof(CollectionsMenuPage));

            //Collections Children
            Routing.RegisterRoute(nameof(CollectionsPage), typeof(CollectionsPage));
            Routing.RegisterRoute(nameof(CollectionsImagesPage), typeof(CollectionsImagesPage));
            Routing.RegisterRoute(nameof(CollectionsButtonPage), typeof(CollectionsButtonPage));
            Routing.RegisterRoute(nameof(CollectionEditPage), typeof(CollectionEditPage));
            Routing.RegisterRoute(nameof(CollectionsAddPage), typeof(CollectionsAddPage));
            

        }
    }
}
