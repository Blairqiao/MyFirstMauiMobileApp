using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Entities;
using MyFirstMauiMobileApp.Model.Titles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMauiMobileApp.ViewModel;

public partial class CollectionsImageViewModel : ObservableObject
{
    private List<MarvelCharacters> _marvelcharacters;
    public string title => TitleCollectionsImages.Title;

    //= new() -> constructs an empty ObservableCollection<MarvelMovies>
    //and assigns it to the property — using the target-typed new() shorthand.
    //Same as -> ObservableCollection<MarvelMovies> MarvelMoviesCollection =
    //  new ObservableCollection<MarvelMovies>();
    public ObservableCollection<MarvelCharacters> MarvelCharactersCollection { get; } = new();

    public CollectionsImageViewModel()
    {
        _marvelcharacters = MarvelCharacters.GetMovies();
        LoadMovies();
    }

    private void LoadMovies()
    {
        try
        {
            MarvelCharactersCollection.Clear();
            foreach (var p in _marvelcharacters)
            {
                MarvelCharactersCollection.Add(new MarvelCharacters { NameofCharacter = p.NameofCharacter , NameofActor = p.NameofActor, ImagePath = p.ImagePath});
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }
}
