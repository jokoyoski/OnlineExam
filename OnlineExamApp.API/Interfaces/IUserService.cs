using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUserService
    {
         Task<IUserScoreForDisplayDto> GetUserScoreByUserId(int userId);
    }
}