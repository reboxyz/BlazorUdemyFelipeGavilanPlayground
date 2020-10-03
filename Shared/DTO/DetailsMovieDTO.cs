using System.Collections.Generic;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Shared.DTO
{
    public class DetailsMovieDTO
    {
        public Movie Movie { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Person> Actors { get; set; }
        public double AverageVote { get; set; }
        public int UserVote { get; set; }
    }
}