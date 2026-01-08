using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ControlsSliderMenuPage : ContentPage
{
	public ControlsSliderMenuPage()
	{
		InitializeComponent();
		BindingContext = new ControlsSliderMenuViewModel();
	}
}