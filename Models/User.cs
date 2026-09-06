using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public enum UserStatus
    {
        Active,
        Inactive,
        Locked,
        Expired
    }

    public enum Gender
    {
        Unknown = 0,
        Male = 1,
        Female = 2
    }

    [Table("Users")]
    public class User
    {
        [Key]
        public Guid Id { get; set; } 

        [Required]
        public Guid RoleId { get; set; } 

        [Required]
        [MaxLength(20)]
        public string UserCode { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required] 
        public byte[] PasswordHash { get; set; } = Array.Empty<byte>();
        
        [Required] 
        public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [MaxLength(15)]
        public string? PhoneNumber { get; set; }

        public DateOnly? DateOfBirth { get; set; } 

        public Gender Gender { get; set; } = Gender.Unknown;

        [MaxLength(255)]
        public string? AvatarUrl { get; set; }

        [MaxLength(255)]
        public string? Address { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public UserStatus Status { get; set; } = UserStatus.Active;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        [ForeignKey(nameof(RoleId))]
        public Role? Role { get; set; }
        
    }
}