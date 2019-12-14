using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IScoreRepository
    {
        Task<IEnumerable<IScore>> GetScoresCollectionByCategoryId(int categoryId);
        Task<IScore> GetScoresByUserIdAndCategoryId(int userId, int categoryId);
        Task<string> SaveScoreHistory(IScore score);
        Task<string> UpdateScoreHistory(IScore score);
    }
}