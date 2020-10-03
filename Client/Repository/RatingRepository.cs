using System;
using System.Threading.Tasks;
using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repository
{
    public class RatingRepository : IRatingRepository
    {
        private readonly string baseUrl = "api/rating";
        private readonly IHttpService _httpService;
        public RatingRepository(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task Vote(MovieRating movieRating)
        {
           var httpResponse = await _httpService.Post(baseUrl, movieRating);

           if (!httpResponse.Success)
           {
               throw new ApplicationException(await httpResponse.GetBody());
           }
        }

    }
}