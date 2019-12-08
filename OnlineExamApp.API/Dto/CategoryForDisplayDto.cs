using System;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class CategoryForDisplayDto : ICategoryForDisplayDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int Duration { get; set; }
        public int NumberofQueston { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int PhotoId { get; set; }
        public string PhotoUrl { get; set; }
    }
}