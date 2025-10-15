using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class LayoutsVerticalStackPage : ContentPage
{
	public LayoutsVerticalStackPage()
	{
		InitializeComponent();
        BindingContext = new LayoutsVerticalStackViewModel();

    }
}