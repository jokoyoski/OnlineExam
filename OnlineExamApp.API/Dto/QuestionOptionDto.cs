using System.Collections.Generic;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class QuestionOptionDto
    {
        public IQuestion Question { get; set; }
        public IList<IOption> Options { get; set; }
        
    }
}