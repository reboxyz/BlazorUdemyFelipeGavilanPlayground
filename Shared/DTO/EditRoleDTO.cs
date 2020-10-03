using System.ComponentModel.DataAnnotations;

namespace BlazorMovies.Shared.DTO
{
    public class EditRoleDTO
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}