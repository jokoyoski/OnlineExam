using System;

namespace OnlineExamApp.API.Interfaces
{
    public interface IScoreDto
    {
         int ScoreId { get; set; }
         decimal Value { get; set; }
         string Username { get; set; }
         int UserId { get; set; }
         string CategoryName { get; set; }
         int CategoryId { get; set; }
         DateTime DateCreated { get; set; }
         DateTime? DateModified { get; set; }
    }
}