using System;
using System.Collections.Generic;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUser
    {
        string Gender { get; set; }
        DateTime DateOfBirth { get; set; }
        string KnownAs { get; set; }
        DateTime Created { get; set; }
        DateTime LastActive { get; set; }
        string City { get; set; }
        ICollection<UserRole> UserRoles { get; set; }
    }
}