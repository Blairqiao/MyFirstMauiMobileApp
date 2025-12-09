using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class CollectionsIconPage : ContentPage
{
	public CollectionsIconPage(CollectionsButtonViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}