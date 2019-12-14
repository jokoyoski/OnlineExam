using System.Collections.Generic;

namespace OnlineExamApp.API.Interfaces
{
    public interface IProcessAnswerReturnDto
    {
        decimal Score { get; set; }
        IList<IScore> highScoreCollection { get; set; }
        int Trials { get; set; }
        int Position { get; set; }
        string ReturnMessage { get; set; }
    }
}