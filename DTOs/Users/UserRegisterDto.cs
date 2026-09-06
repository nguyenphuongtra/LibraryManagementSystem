using System;
using System.ComponentModel.DataAnnotations;
using LibraryManagementSystem_BE.Models;

namespace LibraryManagementSystem_BE.DTOs.Users
{
    public class UserRegisterDto
    {
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MinLength(8)]
        [MaxLength(100)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Phone]
        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        public DateOnly? DateOfBirth { get; set; }

        public Gender Gender { get; set; } = Gender.Unknown;

        [MaxLength(255)]
        public string? Address { get; set; }
    }
}
