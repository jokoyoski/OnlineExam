using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Model
{
    public class Question : IQuestion
    {
        public int QuestionId { get; set; }
        public string Questions { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int CategoryId { get; set; }
    }
}