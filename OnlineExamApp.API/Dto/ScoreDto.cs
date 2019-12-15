using System;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class ScoreDto : IScoreDto
    {
        public int ScoreId { get; set; }
        public decimal Value { get; set; }
        public string Username { get; set; }
        public int UserId { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }   
    }
}