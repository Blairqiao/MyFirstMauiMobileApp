using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMauiMobileApp.Model.Titles;
using MyFirstMauiMobileApp.View;

namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class ControlsEntryVMViewModel : ObservableObject
    {

        public string Title => TitleControl.EntryVMTitle;

        [ObservableProperty]
        private string entryText;

        [RelayCommand]
        private async Task EntryClicked()
        {
            if (string.IsNullOrWhiteSpace(EntryText))
            {
                await Shell.Current.DisplayAlert(TitleControl.EntryVMTitle, "Entry is empty. Please enter text.", "OK");
            }
            else
            {
                await Shell.Current.GoToAsync($"{nameof(ControlsEntryResultsPage)}?entryText={EntryText}");
            }
        }
    }
}
