using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ImagesPage : ContentPage
{
	public ImagesPage()
	{
		InitializeComponent();
        BindingContext = new ImagesViewModel();
    }
}