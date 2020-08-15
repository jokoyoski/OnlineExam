using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IRoleService
    {
        Task<IList<Role>> Roles();
        Task<Role> GetRole(int id);
        Task<string> AddRole(Role role);
        Task<string> EditRole(Role role);
        Task<string> RemoveRole(Role role);
        
    }
}