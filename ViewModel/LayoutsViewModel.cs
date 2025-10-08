using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMauiMobileApp.Model.Titles;
using MyFirstMauiMobileApp.View;

namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class LayoutsViewModel : ObservableObject
    {

        [ObservableProperty]
        private string title = TitleLayouts.LayoutsTitle;
        [ObservableProperty]
        private string stack_Layout = TitleLayouts.Stack_Layout;
        [ObservableProperty]
        private string absolute_Layout = TitleLayouts.Absolute_Layout;
        [ObservableProperty]
        private string vertical_Stack = TitleLayouts.Vertical_Stack;
        [ObservableProperty]
        private string horizontal_Stack = TitleLayouts.Horizontal_Stack;
        [ObservableProperty]
        private string flex_Layout = TitleLayouts.Flex_Layout;


        [RelayCommand]
        private async Task StackLayoutClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsStackPage));
        }

        public LayoutsViewModel() 
        {

        
        }
    }
}
