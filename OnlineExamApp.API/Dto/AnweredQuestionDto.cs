using System.Collections.Generic;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Dto
{
    public class AnweredQuestionDto : IAnweredQuestionDto
    {
        public int QuestionId { get; set; }
        public int OptionId { get; set; }
        public int CategoryId { get; set; }
    }
}