using System.Collections.Generic;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUserScoreForDisplayDto
    {
         int UserId { get; set; } 
        
        IList<ICategoryScore> CategoryScoreCollection { get; set; }
    }
}