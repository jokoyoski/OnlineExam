using System;

namespace OnlineExamApp.API.Interfaces
{
    public interface IOption
    {
        int OptionId { get; set; }
        string OptionName { get; set; }
        bool IsCorrect { get; set; }
        int QuestionId { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateModified { get; set; }    
    }
}