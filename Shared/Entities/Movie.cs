using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorMovies.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
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

    }
}