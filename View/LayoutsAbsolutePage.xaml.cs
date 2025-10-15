using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class LayoutsAbsolutePage : ContentPage
{
	public LayoutsAbsolutePage()
	{
		InitializeComponent();
		BindingContext = new LayoutsAbsoluteViewModel();
	}
}