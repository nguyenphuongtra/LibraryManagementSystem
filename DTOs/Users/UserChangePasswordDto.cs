using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem_BE.DTOs.Users
{
    public class UserChangePasswordDto
    {
        [Required]
        public string CurrentPassword { get; set; } = string.Empty;

        [Required]
        [MinLength(8)]
        [MaxLength(100)]
        public string NewPassword { get; set; } = string.Empty;
    }

}