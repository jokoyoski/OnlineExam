using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class CategoryScore : ICategoryScore
    {
        public string CategoryName { get; set; }    
        public decimal PercentageAverageScore { get; set; }
    }
}