using System.Collections.Generic;

namespace OnlineExamApp.API.Interfaces
{
    public interface IQuestionForDisplay
    {
        int QuestionId { get; set;}
        string Questions { get; set; }
        int CategoryId { get; set; }
        IEnumerable<IOptionsForDisplay> Options { get; set; }
    }
}