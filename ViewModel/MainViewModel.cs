using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMauiMobileApp.Model.Titles;
using MyFirstMauiMobileApp.View;

namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        private string title = TitleMain.Title;
        [ObservableProperty]
        private string layouts = TitleMain.Layouts;
        [ObservableProperty]
        private string images = TitleMain.Images;
        [ObservableProperty]
        private string collections = TitleMain.Collections;
        [ObservableProperty]
        private string controls = TitleMain.Controls;
        [ObservableProperty]
        private string sQL_Lite = TitleMain.SQL_Lite;

        public MainViewModel() 
        {
        
        }

        [RelayCommand]
        private async Task LayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsPage));
        }

        [RelayCommand]
        private async Task ImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesPage));
        }

        [RelayCommand]
        private async Task CollectionsClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionsMenuPage));
        }
    }
}
