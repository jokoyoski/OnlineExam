using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Model
{
    public class User : IdentityUser<int>, IUser
    {
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string City { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

    }
}