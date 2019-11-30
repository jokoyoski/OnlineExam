namespace OnlineExamApp.API.Interfaces
{
    public interface IUserForLoginDto
    {
        string Username { get; set; }
        string Password { get; set; }
    }
}