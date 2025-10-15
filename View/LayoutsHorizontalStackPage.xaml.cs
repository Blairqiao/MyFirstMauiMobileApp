using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class LayoutsHorizontalStackPage : ContentPage
{
	public LayoutsHorizontalStackPage()
	{
		InitializeComponent();
		BindingContext = new LayoutsHorizontalStackViewModel();
	}
}