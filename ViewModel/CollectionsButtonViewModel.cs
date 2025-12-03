using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MyFirstMauiMobileApp.Model.Entities;
using MyFirstMauiMobileApp.Model.Messages;
using MyFirstMauiMobileApp.Model.Titles;
using MyFirstMauiMobileApp.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMauiMobileApp.ViewModel
{
    public partial class CollectionsButtonViewModel : ObservableObject
    {

        public string Title => TitleCollectionsButton.Title;

        [ObservableProperty]
        private bool isBusy;

        [ObservableProperty]
        private ObservableCollection<MarvelMovies> movieCollection = new();

        public CollectionsButtonViewModel() 
        {

            WeakReferenceMessenger.Default.Register<UpdateMovieMessages>(this, (r, m) =>
            {
                var oldTitle = m.OldValue.NameofMovie;
                var idx = MovieCollection.ToList().FindIndex(x  => x.NameofMovie == oldTitle);

                if (idx >= 0) MovieCollection[idx] = m.NewValue;
            });

            RefreshCommand.Execute(null);
        }

        [RelayCommand]
        private async Task Refresh()
        {
            if (IsBusy) return;
            IsBusy = true;

            await Task.Run(() =>
            {
                MovieCollection.Clear();
                foreach (var mov in MarvelMovies.GetMovies())
                {
                    MovieCollection.Add(mov);
                }
            });

            IsBusy = false;
        }

        [RelayCommand]
        private async Task Add()
        {
            WeakReferenceMessenger.Default.Unregister<AddMovieMessage>(this);

            await Shell.Current.GoToAsync(nameof(CollectionsAddPage));

            WeakReferenceMessenger.Default.Register<AddMovieMessage>(this, (r, m) =>
            {
                MovieCollection.Add(m.Value);
                WeakReferenceMessenger.Default.Unregister<AddMovieMessage>(this);
            });
        }

        [RelayCommand]
        private async Task Update(MarvelMovies movie)
        {
            string encodedName = Uri.EscapeDataString(movie.NameofMovie);
            await Shell.Current.GoToAsync($"{nameof(CollectionEditPage)}?movieName={encodedName}");
        }

        [RelayCommand]
        private async Task Delete(MarvelMovies movie)
        {
            MovieCollection.Remove(movie);    
        }

    }
}
