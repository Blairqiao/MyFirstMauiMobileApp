using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Entities;
using MyFirstMauiMobileApp.Model.Titles;
using System.Collections.ObjectModel;
using System.Diagnostics;


namespace MyFirstMauiMobileApp.ViewModel;

public partial class CollectionsViewModel : ObservableObject
{
    private List<MarvelMovies> _marvelmovies;
    public string title => TitleCollections.Title;

    //= new() -> constructs an empty ObservableCollection<MarvelMovies>
    //and assigns it to the property — using the target-typed new() shorthand.
    //Same as -> ObservableCollection<MarvelMovies> MarvelMoviesCollection =
    //  new ObservableCollection<MarvelMovies>();
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


