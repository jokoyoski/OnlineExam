using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUserScoreRepository
    {
         Task<string> SaveUserScore(IUserScore userScore);
    }
}