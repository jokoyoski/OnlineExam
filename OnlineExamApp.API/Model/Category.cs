using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Model
{
    public class Category : ICategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Duration { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int DigitalId { get; set; }

    }
}