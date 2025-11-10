using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ImagesActivityIndicatorPage : ContentPage
{
	public ImagesActivityIndicatorPage()
	{
		InitializeComponent();
		BindingContext = new ImagesActivityIndicatorViewModel();
	}
}