using System;

namespace OnlineExamApp.API.Interfaces
{
    public interface IQuestion
    {
        int QuestionId { get; set; }
        string Questions { get; set; }
        int CategoryId { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateModified { get; set; }
    }
}