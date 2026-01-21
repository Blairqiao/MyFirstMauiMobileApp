

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMauiMobileApp.Model.Titles;
using MyFirstMauiMobileApp.View;

namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class ControlsEntryMenuViewModel : ObservableObject
    {

        public string Title => TitleControl.SliderMenuTitle;

        [RelayCommand]
        private async Task VMClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsEntryVMPage));
        }

        [RelayCommand]
        private async Task XAMLClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsEntryXAMLPage));
        }


    }
}
