using System.Collections.Generic;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class ProcessAnswerReturnDto : IProcessAnswerReturnDto
    {
        public decimal Score { get; set; }  
        public IList<IScore> highScoreCollection { get; set; }
        public int Trials { get; set; }
        public int Position { get; set; }
        public string ReturnMessage { get; set; }
    }
}