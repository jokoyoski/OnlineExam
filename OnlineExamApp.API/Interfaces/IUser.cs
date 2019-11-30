using System;
using System.Collections.Generic;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUser
    {
        DateTime DateOfBirth { get; set; }
        DateTime Created { get; set; }
    
        public string Password {get;set;}
        string FirstName {get;set;}

        string LastName {get;set;}
        ICollection<UserRole> UserRoles { get; set; }
    }
}