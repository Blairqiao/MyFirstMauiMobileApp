using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Titles;



namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class ImagesActivityIndicatorViewModel : ObservableObject
    {

        public string Title => TitleImagesActivityIndicator.Title;

        [ObservableProperty]
        private bool isLoading = true;

        [ObservableProperty]
        private bool isImageVisible = false;

        [ObservableProperty]
        private ImageSource loadedImage;

        public ImagesActivityIndicatorViewModel()
        {
            _ = LoadImageAsync();
        }

        private async Task LoadImageAsync()
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync(TitleImagesURI.ImageURL);

                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    LoadedImage = ImageSource.FromStream(() => stream);
                    IsImageVisible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }
        }

    }
}
