using System.Collections.Generic;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IAnweredQuestionDto
    {
        int QuestionId { get; set; }
        IList<Option> Options { get; set; }
        int CategoryId { get; set; }
    }
}