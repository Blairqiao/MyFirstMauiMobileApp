using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMauiMobileApp.Model.Titles;


namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class ControlsSliderXAMLViewModel : ObservableObject
    {

        public string Title => TitleControl.SliderXAMLTitle;

    }
}
