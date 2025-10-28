using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Titles;


namespace MyFirstMauiMobileApp.ViewModel
{
    partial class LayoutsHorizontalStackViewModel : ObservableObject
    {

        [ObservableProperty]
        private string title = TitleLayoutsHorizontalStack.Title;

        public LayoutsHorizontalStackViewModel()
        {

        }

    }
}
