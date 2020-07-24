using System.ComponentModel.DataAnnotations;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class UserForLoginDto : IUserForLoginDto
    {
        [Required(ErrorMessage="Please Enter Username")]
        public string Username { get; set; }
        
        [Required(ErrorMessage="Please Enter Password")]
        public string Password { get; set; }
    }
}