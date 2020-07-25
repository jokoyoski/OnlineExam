using System.Threading.Tasks;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUserRepository
    {
         Task<User> GetUserById(int userId);
    }
}