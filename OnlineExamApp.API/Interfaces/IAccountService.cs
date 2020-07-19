using System.Threading.Tasks;
using OnlineExamApp.API.Dto;

namespace OnlineExamApp.API.Interfaces
{
    public interface IAccountService
    {
         Task<string> SignUp(UserForRegisterDto userForRegisterDto);
         Task<string> SignIn(UserForLoginDto userForLogInDto);
         Task<string> ProcessConfirmEmail(string email, string code);
         Task<string> ProcessChangePassword(IChangePasswordDto changePasswordDto);
         Task<string> GetTrials(int userId, int numberOfTrials);
    }
}