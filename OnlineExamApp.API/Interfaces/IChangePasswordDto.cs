namespace OnlineExamApp.API.Interfaces
{
    public interface IChangePasswordDto
    {
        string Email { get; set; }
        string Token { get; set; }
        string NewPassword { get; set; }
    }
}