using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Titles;


namespace MyFirstMauiMobileApp.ViewModel
{
    partial class LayoutsVerticalStackViewModel : ObservableObject
    {

        [ObservableProperty]
        private string title = TitleLayoutsVerticalStack.Title;

        public LayoutsVerticalStackViewModel()
        {

        }

    }
}
