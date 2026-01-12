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

        public string Title => TitleControl.StepperVMTitle;


        [ObservableProperty]
        private double stepperValue;

        [ObservableProperty]
        private string labelText;

        [ObservableProperty]
        private string textColor;

        Random random = new Random();


        public ControlsStepperVMViewModel()
        {
            StepperValue = 0;
            LabelText = $"The Stepper Value is {StepperValue:F0}";
            textColor = "#7b43de";
        }

        partial void OnStepperValueChanged(double value) => UpdateVisuals(value);

        private void UpdateVisuals(double Value)
        {
            LabelText = $"The Stepper Value is {Value:F0}";
            int r = random.Next(0, 255);
            int g = random.Next(0, 255);
            int b = random.Next(0, 255);
            TextColor =  $"#{r:X2}{g:X2}{b:X2}";


        }


    }
}
