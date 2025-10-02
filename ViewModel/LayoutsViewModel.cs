using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Titles;

namespace MyFirstMauiMobileApp.ViewModel
{
    class LayoutsViewModel : ObservableObject
    {
        [ObservableProperty]
        public string title = TitleLayouts.LayoutsTitle;
        [ObservableProperty]
        private string stack_layout = TitleLayouts.Stack_Layout;
        [ObservableProperty]
        public string absolute_layout = TitleLayouts.Absolute_Layout;
        [ObservableProperty]
        public string verticale_stack = TitleLayouts.Vertical_Stack;
        [ObservableProperty]
        public string horizontal_stack = TitleLayouts.Horizontal_Stack;

        public LayoutsViewModel() 
        {

        
        }
    }
}
