using System;
using System.ComponentModel.DataAnnotations;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class UserForRegisterDto
    {
        public UserForRegisterDto()
        {
            DateCreated = DateTime.UtcNow;
        }

        [Required(ErrorMessage="Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage="Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage="Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage="First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="Password is required")]
        public string Password { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateCreated { get; set;}
    }
}