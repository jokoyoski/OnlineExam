using System;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Model
{
    public class Score : IScore
    {
        public int ScoreId { get; set; }
        public decimal Value { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}