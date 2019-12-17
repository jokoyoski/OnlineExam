using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class Chat : IChat
    {
        public string Label { get; set; }
        public decimal[] Data { get; set; }
    }
}