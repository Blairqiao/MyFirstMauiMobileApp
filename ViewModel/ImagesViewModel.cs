using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMauiMobileApp.Model.Titles;
using MyFirstMauiMobileApp.View;


namespace MyFirstMauiMobileApp.ViewModel
{
    partial class ImagesViewModel : ObservableObject
    {

        public string Title => TitleImages.Title;
        public string URI => TitleImages.URI;
        public string Embedded => TitleImages.Embedded;
        public string ActivityIndicator => TitleImages.ActivityIndicator;


        [RelayCommand]
        private async Task URIClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesURIPage));
        }

        [RelayCommand]
        private async Task EmbeddedClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesEmbeddedPage));
        }

        [RelayCommand]
        private async Task ActivityIndicatorClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesActivityIndicatorPage));
        }

        public ImagesViewModel()
        {

        }

    }
}
