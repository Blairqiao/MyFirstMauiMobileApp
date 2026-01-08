using CommunityToolkit.Mvvm.Input;
using MyFirstMauiMobileApp.Model.Titles;
using MyFirstMauiMobileApp.View;


namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class ControlsSliderMenuViewModel
    {

        public string Title => TitleControl.SliderMenuTitle;

        [RelayCommand]
        private async Task VMClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSliderPage));
        }

        [RelayCommand]
        private async Task XAMLClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSliderXAMLpage));
        }

    }
}
