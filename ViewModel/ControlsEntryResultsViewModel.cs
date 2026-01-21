using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Titles;


namespace MyFirstMauiMobileApp.ViewModel
{
    [QueryProperty(nameof(EntryText), "entryText")]
    public partial class ControlsEntryResultsViewModel : ObservableObject
    {
        public string Title => TitleControl.EntryResultTitle;

        [ObservableProperty]
        private string entryText;

    }
}
