namespace OnlineExamApp.API.Interfaces
{
    public interface IProcessAnswerReturnDto
    {
        decimal Score { get; set; }
        string ReturnMessage { get; set; }
    }
}