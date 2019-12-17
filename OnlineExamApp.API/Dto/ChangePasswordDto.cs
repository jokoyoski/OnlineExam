using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class ChangePasswordDto : IChangePasswordDto
    {
        public int UserId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}