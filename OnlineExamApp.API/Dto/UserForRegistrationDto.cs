using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineExamApp.API.Dto
{
    public class UserForRegistrationDto
    {
        public UserForRegistrationDto()
        {
            Created = DateTime.UtcNow;
        }

        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password bewteen 4 and 8 character")]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string City { get; set; }   
        public DateTime Created { get; set; }
        
    }
}