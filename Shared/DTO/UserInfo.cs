using System.ComponentModel.DataAnnotations;

namespace BlazorMovies.Shared.DTO
{
    public class UserInfo
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }     // Note! This serves as the Username at the same time
        [Required]
        public string Password { get; set; }
    }
}