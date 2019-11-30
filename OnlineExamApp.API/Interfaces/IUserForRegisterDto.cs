using System;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUserForRegisterDto
    {
        string Username { get; set; }
        string Email { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        string Password { get; set; }
        DateTime DateOfBirth { get; set; }
    }
}