using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class ProcessAnswerReturnDto : IProcessAnswerReturnDto
    {
        public decimal Score { get; set; }  
        public string ReturnMessage { get; set; }
    }
}