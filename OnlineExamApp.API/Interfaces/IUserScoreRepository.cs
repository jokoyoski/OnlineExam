using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUserScoreRepository
    {
        Task<IEnumerable<IUserScore>> GetUserScoresByUserId(int userId);
        Task<IEnumerable<IUserScore>> GetUserScoresByUserIdAndCategoryId(int userId, int categoryId);
        Task<IEnumerable<IUserScore>> GetUserScoresByCategoryId(int categoryId);
        Task<string> SaveUserScore(IUserScore userScore);
    }
}