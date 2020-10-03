using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BlazorMovies.Server
{
    public class Seed
    {
        public static async Task SeedData(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            // Create Administrator User
            var adminEmail = "administrator@test.com";
            var adminUser = await userManager.FindByNameAsync(adminEmail);
            var adminUserId = "2cdd5ed6-edd3-4d26-91db-796219252301";
            if (adminUser == null)
            {
                adminUser = new IdentityUser{
                    Id = adminUserId,
                    Email = adminEmail,
                    UserName = adminEmail
                };

                await userManager.CreateAsync(adminUser, "Pa$$w0rd");

                // Add Admin Role
                await userManager.AddClaimAsync(adminUser, new Claim(ClaimTypes.Role, "Admin"));

                //dbContext.SaveChanges();
            }
        }
        
    }
}