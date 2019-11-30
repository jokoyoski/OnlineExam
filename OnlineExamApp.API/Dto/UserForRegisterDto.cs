using System;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class UserForRegisterDto
    {
        public UserForRegisterDto(){
            DateCreated = DateTime.UtcNow;
        }
        public string Username { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateCreated { get; set;}
    }
}