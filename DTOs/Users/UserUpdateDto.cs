using System;
using System.ComponentModel.DataAnnotations;
using LibraryManagementSystem_BE.Models;

namespace LibraryManagementSystem_BE.DTOs.Users
{
    public class UserUpdateDto
    {
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Phone]
        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        public DateOnly? DateOfBirth { get; set; }

        public Gender Gender { get; set; } = Gender.Unknown;

        [MaxLength(255)]
        public string? AvatarUrl { get; set; }

        [MaxLength(255)]
        public string? Address { get; set; }
    }

}