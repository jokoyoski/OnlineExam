using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class UserForLoginDto : IUserForLoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}