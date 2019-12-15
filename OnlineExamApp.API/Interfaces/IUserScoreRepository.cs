using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUserScoreRepository
    {
        Task<IEnumerable<IUserScore>> GetUserScoresByUserId(int userId);
        Task<string> SaveUserScore(IUserScore userScore);
    }
}