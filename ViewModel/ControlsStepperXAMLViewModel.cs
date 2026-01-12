using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class ControlsStepperXAMLViewModel : ObservableObject
    {

        public string Title => TitleControl.StepperVMTitle;

    }
}
