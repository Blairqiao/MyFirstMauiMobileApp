using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ControlsStepperVMPage : ContentPage
{
	public ControlsStepperVMPage()
	{
		InitializeComponent();
		BindingContext = new ControlsStepperVMViewModel();
	}
}