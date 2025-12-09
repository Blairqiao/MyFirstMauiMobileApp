using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MyFirstMauiMobileApp.Model.Entities;
using MyFirstMauiMobileApp.Model.Messages;
using MyFirstMauiMobileApp.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class CollectionsAddViewModel : ObservableObject
    {

        public string Title = TitleCollectionsButton.AddTitle;

        [ObservableProperty]
        private string movieName = string.Empty;

        [RelayCommand]
        private async Task SaveClicked()
        {
            if (string.IsNullOrWhiteSpace(MovieName))
            {
                await Shell.Current.DisplayAlert(Title, Msgs.NotEmpty, "Ok");
                return;
            }

            var movie = new MarvelMovies { NameofMovie = MovieName };

            WeakReferenceMessenger.Default.Send(new AddMovieMessage(movie));

            await Shell.Current.GoToAsync("..");
        }

    }
}
