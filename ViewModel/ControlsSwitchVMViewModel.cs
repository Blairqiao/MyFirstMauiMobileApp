using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class ControlsSwitchVMViewModel : ObservableObject
    {


        [ObservableProperty]
        private bool isOn;

        [ObservableProperty]
        private Color labelColor;


        public ControlsSwitchVMViewModel()
        {
            IsOn = true;
            LabelColor = Color.FromRgb(0, 0, 255);
        }

        partial void OnIsOnChanged(bool value)
        {
            LabelColor = value
                       ? Color.FromRgb(0, 0, 255)
                       : Color.FromRgb(255, 0, 0);
        }


    }
}
