using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMauiMobileApp.Model.Titles;
using MyFirstMauiMobileApp.View;


namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class CollectionsMenuViewModel : ObservableObject
    {

        public string Collection => TitleCollectionsMenu.Collection;
        public string CollectionImage => TitleCollectionsMenu.CollectionImage;
        public string CollectionButton => TitleCollectionsMenu.CollectionButton;
        public string CollectionIcon => TitleCollectionsMenu.CollectionIcon;

        [RelayCommand]
        private async Task CollectionClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionsPage));
        }

        [RelayCommand]
        private async Task CollectionImageClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionsImagesPage));
        }

        //[RelayCommand]
        //private async Task ActivityIndicatorClicked()
        //{
        //    await Shell.Current.GoToAsync(nameof(ImagesActivityIndicatorPage));
        //}

        //[RelayCommand]
        //private async Task CollectionIconClicked()
        //{
        //    await Shell.Current.GoToAsync(nameof());
        //}

        public CollectionsMenuViewModel()
        {
        }
    }
}
