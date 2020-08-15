using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUserRepository
    {
        Task<IUser> GetUserById(int userId);
        Task<string> Activate(IUser user);
        Task<string> RemoveUser(IUser user);
        Task<string> DeactivateUser(IUser user, int days = 30);
        Task<string> AddUser(IUser user);
        Task<IList<User>> Users();
        Task<string> EditUser(IUser user);
        Task<string> AddUserToRole(User user, string role);
        Task<string> RemoveUserFromRole(User user1, string role);
        Task<IList<string>> UserToRole(User user);
    }
}