using System.Collections.Generic;
using OnlineExamApp.API.Dto;

namespace OnlineExamApp.API.Interfaces
{
    public interface IProcessAnswerReturnDto
    {
        decimal Score { get; set; }
        decimal HighestScore { get; set; } 
        IList<IScoreDto> ScoreBoardCollection { get; set; }
        int Trials { get; set; }
        int Position { get; set; }
        int NoOfParticipant { get; set; }
        string ReturnMessage { get; set; }
    }
}