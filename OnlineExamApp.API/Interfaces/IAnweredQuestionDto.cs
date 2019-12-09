using System.Collections.Generic;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IAnweredQuestionDto
    {
        int QuestionId { get; set; }
        int OptionId { get; set; }
        int CategoryId { get; set; }
    }
}