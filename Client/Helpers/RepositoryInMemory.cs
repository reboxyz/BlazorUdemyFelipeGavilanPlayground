using System;
using System.Collections.Generic;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>{
                new Movie{
                    Title = "Movie 1",
                    ReleaseDate = new DateTime(2020, 12, 3)
                },
                new Movie{
                    Title = "Movie 2",
                    ReleaseDate = new DateTime(2010, 11, 25)
                },  
                new Movie{
                    Title = "Movie 3",
                    ReleaseDate = new DateTime(2015, 10, 15)
                },
            };
        }
    }
}