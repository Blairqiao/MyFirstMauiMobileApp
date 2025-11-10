using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ImagesURIPage : ContentPage
{
	public ImagesURIPage()
	{
		InitializeComponent();
        BindingContext = new ImagesURIViewModel();
    }
}