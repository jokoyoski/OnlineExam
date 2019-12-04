using System;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUserScore
    {
        int UserScoreId { get; set; }
        int UserId { get; set; }
        decimal Score { get; set; }
        int CategoryId { get; set; }
        DateTime DateCreated { get; set; }
        DateTime DateTaken { get; set; }
    }
}