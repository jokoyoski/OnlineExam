using System.Collections.Generic;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class QuestionForDisplay : IQuestionForDisplay
    {
        public int QuestionId { get; set;}
        public string Questions { get; set; }
        public IEnumerable<IOptionsForDisplay> Options { get; set; }
    }
}