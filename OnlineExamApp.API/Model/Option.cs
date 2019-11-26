using System;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Model
{
    public class Option : IOption
    {
        public int OptionId { get; set; }
        public string OptionName { get; set; }
        public bool IsCorrect { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}