using System;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface ICategory
    {
        int CategoryId { get; set; } 
        string CategoryName { get; set; }
        int Duration { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateModified { get; set; }
        int DigitalId { get; set; }
    }
}