using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Entities;
using MyFirstMauiMobileApp.Model.Titles;
using System.Collections.ObjectModel;
using System.Diagnostics;


namespace MyFirstMauiMobileApp.ViewModel;

public partial class CollectionsViewModel : ObservableObject
{
    private List<MarvelMovies> _marvelmovies;
    public string Title => TitleCollections.Title;


    public ObservableCollection<MarvelMovies> MarvelMoviesCollection { get; } = new();

    public CollectionsViewModel()
    {
        _marvelmovies = MarvelMovies.GetMovies();
        LoadMovies();
    }

    private void LoadMovies()
    {
        try
        {
            MarvelMoviesCollection.Clear();
            foreach (var p in _marvelmovies)
            {
                MarvelMoviesCollection.Add(new MarvelMovies { NameofMovie = p.NameofMovie });
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }
}


