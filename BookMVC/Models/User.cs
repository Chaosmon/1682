using BookMVC.Common;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookMVC.Models
{
    public class User : IdentityUser
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [DisplayName("Ngày sinh")]
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Please enter name")]
        [StringLength(70)]
        public string Name { get; set; }
        //[Required]
        //public string? UserName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string UserEmail { get; set; }
        [Required]
        public string UserPassword { get; set; }
        [Required]
        public UserRole Role { get; set; } // UserRole enum to distinguish between user and admin

        // Additional properties like address, phone number, etc.
        // ...
    }
}
