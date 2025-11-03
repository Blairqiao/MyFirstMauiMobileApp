using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class LayoutsFlexPage : ContentPage
{
	public LayoutsFlexPage()
	{
		InitializeComponent();
		BindingContext = new LayoutsFlexViewModel();
	}
}