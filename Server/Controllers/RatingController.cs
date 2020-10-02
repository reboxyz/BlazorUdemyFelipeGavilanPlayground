using System;
using System.Threading.Tasks;
using BlazorMovies.Server;
using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class RatingController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public RatingController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Rate(MovieRating movieRating)
        {
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            //var user = await _userManager.FindByEmailAsync(HttpContext.User.Identity.Name);
            var userId = user.Id;

            var currentRating = await _context.MovieRatings.FirstOrDefaultAsync(x => 
                x.MovieId == movieRating.MovieId && x.UserId == userId
            );

            if (currentRating == null)  // Not yet rated
            {
                movieRating.UserId = userId;
                movieRating.RatingDate = DateTime.Today;
                _context.MovieRatings.Add(movieRating);
            } else 
            {
                currentRating.Rate = movieRating.Rate;  // update rate
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}