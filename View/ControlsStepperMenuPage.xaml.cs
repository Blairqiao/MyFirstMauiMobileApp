using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ControlsStepperMenuPage : ContentPage
{
	public ControlsStepperMenuPage()
	{
		InitializeComponent();
		BindingContext = new ControlsStepperMenuViewModel();

    }
}