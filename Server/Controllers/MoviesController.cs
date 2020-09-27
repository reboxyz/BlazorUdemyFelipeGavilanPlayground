using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlazorMovies.Server.Helpers;
using BlazorMovies.Shared.DTO;
using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorMovies.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController: ControllerBase
    {
        private int limit = 6;
        private string containerName = "movies";

        private readonly ApplicationDbContext _context;
        private readonly IFileStorageService _fileStorageService;
        private readonly IMapper _mapper;

        public MoviesController(ApplicationDbContext context, IFileStorageService fileStorageService, IMapper mapper)
        {
            _mapper = mapper;
            _fileStorageService = fileStorageService;
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Movie movie)
        {
            if (!string.IsNullOrEmpty(movie.Poster))
            {
                var moviePoster = Convert.FromBase64String(movie.Poster); // From Base64 to byte[]
                movie.Poster = await _fileStorageService.SaveFile(moviePoster, "jpg", containerName);
            }

            // Set Order
            if (movie.MoviesActors != null)
            {
                for(int i = 0; i < movie.MoviesActors.Count; i++)
                {
                    movie.MoviesActors[i].Order = i + 1;
                }
            }

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return Ok(movie.Id);
        }

        [HttpGet]
        public async Task<ActionResult<IndexPageDTO>> GetMovies()
        {
            var moviesInTheaters = await _context.Movies.Where(x => x.InTheaters)
                                        .OrderByDescending(x => x.ReleaseDate)
                                        .Take(limit)
                                        .ToListAsync();

            var upcomingReleases = await _context.Movies.Where(x => x.ReleaseDate > DateTime.Today)
                                    .OrderBy(x => x.ReleaseDate)
                                    .Take(limit)
                                    .ToListAsync();

            var response = new IndexPageDTO();
            response.InTheaters = moviesInTheaters;
            response.UpcomingReleases = upcomingReleases;
            
            return response;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DetailsMovieDTO>> GetMovieDetails(int id)
        {
            var movie = await _context.Movies.Where(x => x.Id == id)
                            .Include(x => x.MoviesGenres).ThenInclude(x => x.Genre)
                            .Include(x => x.MoviesActors).ThenInclude(x => x.Person)
                            .FirstOrDefaultAsync();

            if (movie == null) { return NotFound(); }

            movie.MoviesActors = movie.MoviesActors.OrderBy(x => x.Order).ToList();

            var model = new DetailsMovieDTO();
            model.Movie = movie;
            model.Genres = movie.MoviesGenres.Select(x => x.Genre).ToList();
            model.Actors = movie.MoviesActors.Select(x => new Person
                {
                    Name = x.Person.Name,
                    Picture = x.Person.Picture,
                    Character = x.Character,
                    Id = x.PersonId
                }
            ).ToList();

            return model; 
        }

        [HttpGet("update/{id}")]
        public async Task<ActionResult<MovieUpdateDTO>> PutGet(int id)
        {
            var movieActionResult = await GetMovieDetails(id);
            if (movieActionResult.Result is NotFoundResult)
            {
                return NotFound();
            }

            var movieDetailDTO = movieActionResult.Value;
            var selectedGenresIds = movieDetailDTO.Genres.Select(x => x.Id).ToList();
            var notSelectedGenres = await _context.Genres.Where(x => !selectedGenresIds.Contains(x.Id)).ToListAsync();

            var model = new MovieUpdateDTO();
            model.Movie = movieDetailDTO.Movie;
            model.Actors = movieDetailDTO.Actors;
            model.SelectedGenres = movieDetailDTO.Genres;
            model.NotSelectedGenres = notSelectedGenres;

            return model;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Movie movie)
        {
            var movieDB = await _context.Movies.FirstOrDefaultAsync(x => x.Id == movie.Id);
            if (movieDB == null)
            {
                return NotFound();
            }

            movieDB = _mapper.Map(movie, movieDB); // source -> destination

            if (!string.IsNullOrWhiteSpace(movie.Poster))
            {
                var moviePoster = Convert.FromBase64String(movie.Poster);
                // Note! EditFile is effectively doing Delete and Insert
                movieDB.Poster = await _fileStorageService.EditFile(moviePoster, "jpg", containerName, movieDB.Poster);
            }

            // Update Genres and Actors by using the Delete-and-then-Insert mechanishm
            await _context.Database.ExecuteSqlInterpolatedAsync($"delete from MoviesActors where MovieId = {movie.Id}");
            await _context.Database.ExecuteSqlInterpolatedAsync($"delete from MoviesGenres where MovieId = {movie.Id}");

            // Adjust Order
            if (movie.MoviesActors != null)
            {
                for (int i = 0; i < movie.MoviesActors.Count; i++)
                {
                    movie.MoviesActors[i].Order = i + 1;
                }
            } 

            movieDB.MoviesActors = movie.MoviesActors;
            movieDB.MoviesGenres = movie.MoviesGenres;

            await _context.SaveChangesAsync();
            return NoContent(); 
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost("filter")]  // Note! HttpGet could be used instead using the [FromQuery] but due to the fact that there are many parameter fields, it is convenient to use HttpPost
        public async Task<ActionResult<List<Movie>>> Filter(FilterMoviesDTO filterMoviesDTO)
        {
            var moviesQueryable = _context.Movies.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filterMoviesDTO.Title))
            {
                moviesQueryable = moviesQueryable
                    //.Where(x => x.Title.Contains(filterMoviesDTO.Title, StringComparison.InvariantCultureIgnoreCase));
                .Where(x => x.Title.ToLower().Contains(filterMoviesDTO.Title.ToLower()));
            }

            if (filterMoviesDTO.InTheaters)
            {
                moviesQueryable = moviesQueryable.Where(x => x.InTheaters);
            }

            if (filterMoviesDTO.UpcomingReleases)
            {
                moviesQueryable = moviesQueryable.Where(x => x.ReleaseDate > DateTime.Today);
            }

            if (filterMoviesDTO.GenreId != 0)
            {
                moviesQueryable = moviesQueryable
                    .Where(x => x.MoviesGenres.Select(y => y.GenreId).Contains(filterMoviesDTO.GenreId));
            }

            // Compute the Total Number of Pages and add as a Response Header
            await HttpContext.InsertPaginationParametersInResponse(moviesQueryable, filterMoviesDTO.RecordsPerPage);

            // Execute Query with Skip and Take based on Pagination param
            var movies = await moviesQueryable.Paginate(filterMoviesDTO.Pagination).ToListAsync();
            return movies;
        }

    }
}