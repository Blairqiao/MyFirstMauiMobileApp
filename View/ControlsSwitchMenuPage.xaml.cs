using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ControlsSwitchMenuPage : ContentPage
{
	public ControlsSwitchMenuPage()
	{
		InitializeComponent();
		BindingContext = new ControlsSwitchMenuViewModel();
	}
}