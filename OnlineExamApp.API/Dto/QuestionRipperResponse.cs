using System.Collections.Generic;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Dto
{
    public class QuestionRipperResponse
    {
        public List<QuestionObject> Questions { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
    }
}