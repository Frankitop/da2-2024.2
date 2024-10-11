using Domain;

namespace Models.In
{
    public class CreateMovieRequest
    {
        public string Title { get; set; }
        public IEnumerable<string> Genres { get; set; }

        public Movie ToEntity()
        {
            return new Movie { Title = Title, Genres = Genres.ToList() };
        }
    }
}
