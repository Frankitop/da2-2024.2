using Domain;

namespace Models.Out;

public class MovieImporter
{
    public string Title { get; set; }
    public List<string> Genres { get; set; }
    
    public Movie ToEntity()
    {
        return new Movie { Title = Title, Genres = Genres.ToList() };
    }
}