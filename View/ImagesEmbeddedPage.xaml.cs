using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ImagesEmbeddedPage : ContentPage
{
	public ImagesEmbeddedPage()
	{
		InitializeComponent();
        BindingContext = new ImagesEmbeddedViewModel();
    }
}