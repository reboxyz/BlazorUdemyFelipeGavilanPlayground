using System;

namespace BlazorMovies.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}