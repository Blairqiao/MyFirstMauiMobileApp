using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMauiMobileApp.ViewModel
{
    partial class LayoutsAbsoluteViewModel : ObservableObject
    {

        [ObservableProperty]
        private string title = TitleLayoutsAbsolute.Title;

        public LayoutsAbsoluteViewModel()
        {

        }

    }
}
