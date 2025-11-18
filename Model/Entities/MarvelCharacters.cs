

namespace MyFirstMauiMobileApp.Model.Entities;

public class MarvelCharacters
{
    public string NameofCharacter { get; set; }

    public string NameofActor { get; set; }

    public ImageSource ImagePath { get; set; }

    //Image Buttons
    //public ImageSource EditButton { get; } = Buttons.ButtonEdit;
    //public ImageSource DeleteButton { get; } = Buttons.ButtonDelete;

    public MarvelCharacters()
    {

    }

    public MarvelCharacters(string character, string actor, ImageSource image)
    {
        NameofCharacter = character;
        NameofActor = actor;
        ImagePath = image;
    } 
    public static List<MarvelCharacters> GetMovies() => new List<MarvelCharacters>
    {
        new MarvelCharacters("Chris Pratt", "Starlord", "starlord.png"),
        new MarvelCharacters("Zoe Saldana", "Gamora", "groot.png"),
        new MarvelCharacters("VinDiesel", "Groot", "nebula.png"),
        new MarvelCharacters("Bradley Cooper", "Rocket", "rocket.png"),
        new MarvelCharacters("Karen Gillan", "Nebula", "nebula.png")
     };
}