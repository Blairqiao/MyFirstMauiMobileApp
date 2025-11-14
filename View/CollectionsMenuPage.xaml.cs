using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class CollectionsMenuPage : ContentPage
{
	public CollectionsMenuPage()
	{
		InitializeComponent();
		BindingContext = new CollectionsMenuViewModel();
	}
}