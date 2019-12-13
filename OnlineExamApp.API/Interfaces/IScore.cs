using System;

namespace OnlineExamApp.API.Interfaces
{
    public interface IScore
    {
         int ScoreId { get; set; }
         decimal Value { get; set; }
         int UserId { get; set; }
         int CategoryId { get; set; }
         DateTime DateCreated { get; set; }
         DateTime? DateModified { get; set; }
    }
}