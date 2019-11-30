using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Model
{
    public class User : IdentityUser<int>, IUser
    {

        public DateTime DateOfBirth { get; set; }
        public DateTime Created { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

    }
}