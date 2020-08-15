using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUserService
    {
        Task<IPerformanceDisplayDto> GetUserPerformanceByCatetgory(int userId, int categoryId);

        Task<IUser> GetUserById(int id);
        Task<string>  Activate(IUser user);
        Task<string> RemoveUser(IUser user);
        Task<string> Deactivate(IUser user);
        Task<string> AddUser(IUser user);
        Task<IList<User>> Users();
        Task<string> EditUser(IUser user);
        Task<IList<string>> UserToRole(User user);
        Task<string> AddUserToRole(User user, string role);
        Task<string> RemoveUserFromRole(User user, string role);
    }
}