using System.Collections.Generic;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class UserScoreForDisplayDto : IUserScoreForDisplayDto
    {
        public int UserId { get; set; } 
        
        public IList<ICategoryScore> CategoryScoreCollection { get; set; }
    }
}