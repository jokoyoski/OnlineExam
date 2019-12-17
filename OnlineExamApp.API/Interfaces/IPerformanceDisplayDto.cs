namespace OnlineExamApp.API.Interfaces
{
    public interface IPerformanceDisplayDto
    {
        IChat UserAverageScore { get; set; }
        IChat OverallAverageScore { get; set; }
    }
}