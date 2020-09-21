using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorMovies.Shared.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Name is required field")]
        public string Name { get; set; }
        // Many-to-many relationship between Movie and Genres
        public List<MoviesGenres> MoviesGenres { get; set; } = new List<MoviesGenres>();
    }
}