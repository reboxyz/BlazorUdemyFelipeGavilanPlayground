namespace BlazorMovies.Shared.Entities
{
    // Link table for the Many-to-Many relationship between Movie and Genre
    public class MoviesGenres
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }

        // Navigational Properties
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
    }
}