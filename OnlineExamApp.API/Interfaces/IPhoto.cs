using System;
using System.Collections.Generic;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IPhoto
    {
        int Id { get; set; }
        string Url { get; set; }
        DateTime DateAdded { get; set; }
        string PublicId { get; set; }
        string Description { get; set; }
        ICollection<Category> Categories { get; set; }
        ICollection<User> Users { get; set; }
    }
}