using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class LayoutsStackPage : ContentPage
{
	public LayoutsStackPage()
	{
		InitializeComponent();
        BindingContext = new LayoutsStackViewModel();
    }
}