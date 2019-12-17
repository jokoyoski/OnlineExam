namespace OnlineExamApp.API.Interfaces
{
    public interface IChangePasswordDto
    {
        int UserId { get; set; }
        string OldPassword { get; set; }
        string NewPassword { get; set; }
    }
}