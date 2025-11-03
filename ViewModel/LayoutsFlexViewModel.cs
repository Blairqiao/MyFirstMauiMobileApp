using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Titles;

namespace MyFirstMauiMobileApp.ViewModel
{
    internal class LayoutsFlexViewModel : ObservableObject
    {

        public string Title => TitleLayoutsFlex.Title;

        public LayoutsFlexViewModel()
        {

        }

    }
}
