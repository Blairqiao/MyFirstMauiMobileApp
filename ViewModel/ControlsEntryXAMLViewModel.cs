

using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Titles;

namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class ControlsEntryXAMLViewModel : ObservableObject
    {

        public string Title => TitleControl.EntryXAMLTitle;

    }
}
