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
    public partial class ControlsStepperMenuViewModel : ObservableObject
    {

        public string Title => TitleControl.StepperMenuTitle;

        [RelayCommand]
        private async Task VMClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsStepperVMPage));
        }

        [RelayCommand]
        private async Task XAMLClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlsStepperXAMLPage));
        }


    }
}
