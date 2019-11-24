using System;

namespace OnlineExamApp.API.Interfaces
{
    public interface IQuestion
    {
        int QuestionId { get; set; }
        string Questions { get; set; }
        string OptionA { get; set; }
        string OptionB { get; set; }
        string OptionC { get; set; }
        string OptionD { get; set; }
        string OptionE { get; set; }
        int CategoryId { get; set; }
        string Answer { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
    }
}