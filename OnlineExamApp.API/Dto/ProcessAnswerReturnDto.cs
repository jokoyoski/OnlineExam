using System.Collections.Generic;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class ProcessAnswerReturnDto : IProcessAnswerReturnDto
    {
        public decimal Score { get; set; }
        public decimal HighestScore { get; set; }  
        public IList<IScoreDto> ScoreBoardCollection { get; set; }
        public int Position { get; set; }
        public int NoOfParticipant { get; set; }
        public int Trials { get; set; }
        public string ReturnMessage { get; set; }
    }
}