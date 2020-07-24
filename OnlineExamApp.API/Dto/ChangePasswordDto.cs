using System.ComponentModel.DataAnnotations;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class ChangePasswordDto : IChangePasswordDto
    {

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Token is required")]
        public string Token { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string NewPassword { get; set; }
    }
}