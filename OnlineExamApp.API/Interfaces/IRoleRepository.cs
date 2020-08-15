using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IRoleRepository
    {
        Task<IList<Role>> Roles();
        Task<Role> GetRole(int id);
        Task<Role> AddRole(Role role);
        Task<Role> EditRole(Role role);
        Task<Role> RemoveRole(Role role);
    }
}