using System.ComponentModel.DataAnnotations;

namespace ChessApp.API.Dtos
{
    public class RegisterUserDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Password must be between 4 and 8 characters.")]
        public string Password { get; set; }

        [Required]
        public string Name { get; set; }
    }
}