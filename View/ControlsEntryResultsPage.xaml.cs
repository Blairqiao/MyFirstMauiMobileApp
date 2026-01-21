using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ControlsEntryResultsPage : ContentPage
{
	public ControlsEntryResultsPage()
	{
		InitializeComponent();
		BindingContext = new ControlsEntryResultsViewModel();
    }
}