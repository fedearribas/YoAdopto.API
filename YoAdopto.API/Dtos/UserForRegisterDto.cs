using System;
using System.ComponentModel.DataAnnotations;

namespace YoAdopto.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 8 characters.")]
        public string Password { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime LastActive { get; set; }
        public bool Active { get; set; }

        public UserForRegisterDto()
        {
            CreatedAt = DateTime.Now;
            LastActive = DateTime.Now;
            Active = true;
        }
    }
}