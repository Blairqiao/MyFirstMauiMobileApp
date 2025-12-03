using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class CollectionsButtonPage : ContentPage
{
	public CollectionsButtonPage(CollectionsButtonViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}