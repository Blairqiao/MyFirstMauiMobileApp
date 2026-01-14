using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMauiMobileApp.Model.Titles;
using MyFirstMauiMobileApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class ControlsMenuViewModel : ObservableObject
    {

        public string Title => TitleControl.Title;
        public string Slider => TitleControl.Slider;
        public string Stepper => TitleControl.Stepper;
        public string Switch => TitleControl.Switch;
        
        [RelayCommand]
        private async Task SliderClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSliderMenuPage));
        }

        [RelayCommand]
        private async Task StepperClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsStepperMenuPage));
        }


        [RelayCommand]
        private async Task SwitchClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsSwitchMenuPage));
        }

        public ControlsMenuViewModel()
        {

        }

    }
}
