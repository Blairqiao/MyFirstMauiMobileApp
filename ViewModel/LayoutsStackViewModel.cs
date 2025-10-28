using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Titles;


namespace MyFirstMauiMobileApp.ViewModel
{
    partial class LayoutsStackViewModel : ObservableObject
    {

        [ObservableProperty]
        private string title = TitleLayoutsStack.Title;

        public LayoutsStackViewModel() 
        {
        
        }

    }

}
