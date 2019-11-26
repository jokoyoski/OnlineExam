using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace OnlineExamApp.API.Model
{
    public class Role : IdentityRole<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}