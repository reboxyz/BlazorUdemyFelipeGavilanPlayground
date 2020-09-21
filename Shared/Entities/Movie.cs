using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorMovies.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Summary { get; set; }   // Markdown
        public bool InTheaters { get; set; }
        public string Trailer { get; set; }
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public string Poster { get; set; }
        public string TitleBrief {
            get {
                if (Title.Length > 60) 
                {
                    return Title.Substring(0, 60) + "...";
                } else {
                    return Title;
                }
            }
        }
        // Many-to-many relationship between Movie and Genres
        public List<MoviesGenres> MoviesGenres { get; set; } = new List<MoviesGenres>();

    }
}