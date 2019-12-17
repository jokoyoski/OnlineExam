using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class PerformanceDisplayDto : IPerformanceDisplayDto
    {
        public IChat UserAverageScore { get; set; }
        public IChat OverallAverageScore { get; set; }
    }

}