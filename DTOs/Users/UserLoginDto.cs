using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem_BE.DTOs.Users
{
    public class UserLoginDto
    {
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }

}