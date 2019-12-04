using System;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Model
{
    public class UserScore : IUserScore
    {
        public int UserScoreId { get; set; }
        public int UserId { get; set; }
        public decimal Score { get; set; }
        public int CategoryId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateTaken { get; set; }
    }
}