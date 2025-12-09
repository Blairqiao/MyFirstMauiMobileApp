using CommunityToolkit.Mvvm.ComponentModel;
using MyFirstMauiMobileApp.Model.Entities;
using MyFirstMauiMobileApp.Model.Titles;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyFirstMauiMobileApp.ViewModel;

public partial class CollectionsImageViewModel : ObservableObject
{
    private List<MarvelCharacters> _marvelcharacters;
    public string Title => TitleCollectionsImages.Title;

    public ObservableCollection<MarvelCharacters> MarvelCharactersCollection { get; } = new();

    public CollectionsImageViewModel()
    {
        _marvelcharacters = MarvelCharacters.GetCharacters();
        LoadCharacters();
    }

    private void LoadCharacters()
    {
        try
        {
            MarvelCharactersCollection.Clear();
            foreach (var p in _marvelcharacters)
            {
                MarvelCharactersCollection.Add(new MarvelCharacters { NameofCharacter = p.NameofCharacter
                , NameofActor = p.NameofActor, ImagePath = p.ImagePath});
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }
}
