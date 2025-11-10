using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Titles;

namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class ImagesURIViewModel : ObservableObject
    {

        public string Title => TitleImagesURI.Title;

        [ObservableProperty]
        private ImageSource imageSourceUrl;

        public ImagesURIViewModel()
        {
            ImageSourceUrl = new UriImageSource
            {
                Uri = new Uri(TitleImagesURI.ImageURL),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(1)
            };
        }

    }
}
