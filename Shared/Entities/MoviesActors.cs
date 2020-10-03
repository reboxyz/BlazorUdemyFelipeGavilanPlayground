namespace BlazorMovies.Shared.Entities
{
    // Link table for the Many-to-Many relationship between Movie and Person (Actors)
    public class MoviesActors
    {
        public int PersonId { get; set; }
        public int MovieId  { get; set; }

        // Navigational Properties
        public Person Person { get; set; }
        public Movie Movie { get; set; }

        // Extra fields
        public string Character { get; set; }
        public int Order { get; set; }

    }
}