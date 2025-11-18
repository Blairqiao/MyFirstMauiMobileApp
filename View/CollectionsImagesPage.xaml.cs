using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class CollectionsImagesPage : ContentPage
{
	public CollectionsImagesPage()
	{
		InitializeComponent();
		BindingContext = new CollectionsImageViewModel();
	}
}