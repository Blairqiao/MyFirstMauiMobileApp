using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ControlsSliderPage : ContentPage
{
	public ControlsSliderPage()
	{
		InitializeComponent();
		BindingContext = new ControlsSliderViewModel();
	}

}