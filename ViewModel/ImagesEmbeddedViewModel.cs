
using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Titles;

namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class ImagesEmbeddedViewModel : ObservableObject
    {

        public string Title => TitleImagesEmbedded.Title;

        public ImageSource ImageSource => "nature.jpg";
    
    }
}
