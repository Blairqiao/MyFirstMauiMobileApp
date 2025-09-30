using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMauiMobileApp.Model.Titles;

namespace MyFirstMauiMobileApp.ViewModel
{
    class LayoutsViewModel : BaseViewModel
    {
        public string Stack_Layout { get; set; } = TitleLayouts.Stack_Layout;
        public string Absolute_Layout { get; set; } = TitleLayouts.Absolute_Layout;
        public string Vertical_Stack { get; set; } = TitleLayouts.Vertical_Stack;
        public string Horizontal_Stack { get; set; } = TitleLayouts.Horizontal_Stack;

        public LayoutsViewModel() 
        {

            Title = TitleLayouts.LayoutsTitle;
        
        }
    }
}
