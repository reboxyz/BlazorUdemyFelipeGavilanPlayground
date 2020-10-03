using System.ComponentModel.DataAnnotations;

namespace BlazorMovies.Shared.DTO
{
    public class UserDTO
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Email { get; set; }
    }
}