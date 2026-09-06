using System;
using LibraryManagementSystem_BE.Models;

namespace LibraryManagementSystem_BE.DTOs.Users
{
    public class UserResponseDto
    {
        public Guid Id { get; set; }

        public Guid RoleId { get; set; }

        public string UserCode { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;

        public string? PhoneNumber { get; set; }

        public DateOnly? DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string? AvatarUrl { get; set; }

        public string? Address { get; set; }

        public UserStatus Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string? RoleName { get; set; }
    }

}