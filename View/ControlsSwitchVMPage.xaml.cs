using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ControlsSwitchVMPage : ContentPage
{
	public ControlsSwitchVMPage()
	{
		InitializeComponent();
		BindingContext = new ControlsSwitchVMViewModel();
	}
}