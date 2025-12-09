using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class CollectionEditPage : ContentPage
{
	public CollectionEditPage()
	{
		InitializeComponent();
		BindingContext = new CollectionsEditViewModel();
	}

	public void ApplyQueryAttributes(IDictionary<string, object> query)
	{
		if (query.TryGetValue("movieName", out var raw) && BindingContext is CollectionsEditViewModel vm)
		{
			vm.MovieName = Uri.UnescapeDataString(raw as string ?? string.Empty);
		}
	}
}