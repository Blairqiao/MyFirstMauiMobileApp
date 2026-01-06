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
    public partial class ControlsSliderViewModel : ObservableObject
    {

        [ObservableProperty]
        private double sliderValue;

        public double BoxOpacity;
        public string LabelText;        

        [RelayCommand]
        private void SetToHalf()
        {
            SliderValue = 0.5;
        }

        public ControlsSliderViewModel()
        {
            SliderValue = 1;
            BoxOpacity = SliderValue;
            LabelText = $"Value of the slider is {SliderValue:F2}";
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e) => UpdateVisuals(e.NewValue);

        private void UpdateVisuals(double Value)
        {
            BoxOpacity = Value;
            LabelText = $"Value of the slider is {Value:F2}";

        }


    }
}
