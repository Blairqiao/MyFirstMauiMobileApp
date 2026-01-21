using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ControlsEntryMenuPage : ContentPage
{
	public ControlsEntryMenuPage()
	{
		InitializeComponent();
		BindingContext = new ControlsEntryMenuViewModel();

    }
}