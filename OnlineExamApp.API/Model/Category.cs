using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Model
{
    public class Category : ICategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int Duration { get; set; }
        public int NumberofQueston { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        [JsonIgnore]
        public int PhotoId { get; set; }

        [JsonIgnore]
        public Photo Photo { get; set; }
    }
}