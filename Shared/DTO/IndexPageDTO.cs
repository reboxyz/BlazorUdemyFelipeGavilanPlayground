using System.Collections.Generic;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Shared.DTO
{
    public class IndexPageDTO
    {
        public List<Movie> InTheaters { get; set; }  = new List<Movie>();
        public List<Movie> UpcomingReleases { get; set; }  = new List<Movie>();
    }
}