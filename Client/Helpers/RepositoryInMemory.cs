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
                    Id = 1,
                    Title = "Spider-Man Far From Home",
                    ReleaseDate = new DateTime(2019, 7, 2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"
                },
                new Movie{
                    Id = 2,
                    Title = "Moana",
                    ReleaseDate = new DateTime(2010, 11, 25),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjI4MzU5NTExNF5BMl5BanBnXkFtZTgwNzY1MTEwMDI@._V1_UX182_CR0,0,182,268_AL_.jpg"
                },  
                new Movie{
                    Id = 3,
                    Title = "Inception",
                    ReleaseDate = new DateTime(2015, 10, 15),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg"
                },
            };
        }
    }
}