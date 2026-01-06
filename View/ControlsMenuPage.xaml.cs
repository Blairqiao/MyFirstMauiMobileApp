using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ControlsMenuPage : ContentPage
{
	public ControlsMenuPage()
	{
		InitializeComponent();
		BindingContext = new ControlsMenuViewModel();
	}
}