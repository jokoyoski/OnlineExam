using System;

namespace OnlineExamApp.API.Interfaces
{
    public interface ICategory
    {
        int CategoryId { get; set; } 
        string CategoryName { get; set; }
        int Duration { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateModified { get; set; }
    }
}