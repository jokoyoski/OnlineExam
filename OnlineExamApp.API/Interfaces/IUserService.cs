using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUserService
    {
         Task<IPerformanceDisplayDto> GetUserPerformanceByCatetgory(int userId, int categoryId);
    }
}