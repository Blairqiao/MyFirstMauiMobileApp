using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMauiMobileApp.Model.Titles;
using MyFirstMauiMobileApp.View;


namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class ControlsSliderViewModel : ObservableObject
    {

        public string Title => TitleControl.SliderVMTitle;
        public string IncreasingColor => "LightBlue";
        public string DecreasingColor => "Orange";
        public string ThumbColor => "DarkGreen";


        [ObservableProperty]
        private double sliderValue;

        [ObservableProperty]
        private string labelText;       

        [RelayCommand]
        private void SetToHalf()
        {
            SliderValue = 0.5;
            LabelText = $"Value of the slider is {SliderValue:F2}";
        }

        public ControlsSliderViewModel()
        {
            SliderValue = 1;
        }

        partial void OnSliderValueChanged(double value) => UpdateVisuals(value);

        private void UpdateVisuals(double Value)
        {
            LabelText = $"Value of the slider is {Value:F2}";
        }


    }
}
