namespace OnlineExamApp.API.Interfaces
{
    public interface ICategoryScore
    {
        string CategoryName { get; set; }    
        decimal PercentageAverageScore { get; set; }
    }
}