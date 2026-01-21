using MyFirstMauiMobileApp.Model.Titles;
using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ControlsEntryXAMLPage : ContentPage
{
	public ControlsEntryXAMLPage()
	{
		InitializeComponent();
		BindingContext = new ControlsEntryXAMLViewModel();
	}

    private async void SubmitClicked(object sender, EventArgs e)
	{
        string entryText = EntryValue.Text;

        if (string.IsNullOrWhiteSpace(entryText))
        {
            await Shell.Current.DisplayAlert(TitleControl.EntryXAMLTitle, "Entry is empty. Please enter text.", "OK");


        }
        else
        {
            await Shell.Current.DisplayAlert(TitleControl.EntryXAMLTitle, "You entered: " + entryText, "OK");
        }

    }


}