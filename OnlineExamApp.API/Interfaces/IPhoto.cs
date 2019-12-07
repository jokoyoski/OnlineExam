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
        string Description { get; set; }
    }
}