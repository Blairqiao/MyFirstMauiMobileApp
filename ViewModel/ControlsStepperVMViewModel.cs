using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMauiMobileApp.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class ControlsStepperVMViewModel : ObservableObject
    {

        //public string Title => TitleControl.SliderVMTitle;


        [ObservableProperty]
        private double stepperValue;

        [ObservableProperty]
        private string labelText;


        public ControlsStepperVMViewModel()
        {
            StepperValue = 0;
            LabelText = $"Value of the stepper is {StepperValue:F0}";
        }

        partial void OnStepperValueChanged(double value) => UpdateVisuals(value);

        private void UpdateVisuals(double Value)
        {
            LabelText = $"Value of the stepper is {Value:F0}";
        }


    }
}
