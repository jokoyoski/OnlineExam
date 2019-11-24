using System;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Model
{
    public class Question : IQuestion
    {
        public int QuestionId { get; set; }
        public string Questions { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string OptionE { get; set; }
        public int CategoryId { get; set; }
        public string Answer { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

    }
}