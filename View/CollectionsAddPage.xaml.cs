using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class CollectionsAddPage : ContentPage
{
	public CollectionsAddPage()
	{
		InitializeComponent();
		BindingContext = new CollectionsAddViewModel();
	}
}