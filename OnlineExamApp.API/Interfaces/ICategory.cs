using System;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface ICategory
    {
        int CategoryId { get; set; } 
        string CategoryName { get; set; }
        string CategoryDescription { get; set; }
        int Duration { get; set; }
        int NumberofQueston { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateModified { get; set; }
        int PhotoId { get; set; }
        Photo Photo { get; set; }
    }
}