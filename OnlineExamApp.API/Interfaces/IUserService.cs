using System.Threading.Tasks;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUserService
    {
         Task<IPerformanceDisplayDto> GetUserPerformanceByCatetgory(int userId, int categoryId);

         Task<User> GetUserById(int id);
    }
}