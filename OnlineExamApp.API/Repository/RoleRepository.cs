using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RoleManager<Role> _role;
        private readonly ILogger<RoleRepository> _logger;

        public RoleRepository(RoleManager<Role> role, ILogger<RoleRepository> logger)
        {
            this._role = role;
            this._logger = logger;
        }
        
        public async Task<Role> AddRole(Role role)
        {
            if(role == null) throw new ArgumentNullException(nameof(role));

            try
            {
                await this._role.CreateAsync(role);

            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return role;
        }

        public async Task<Role> EditRole(Role role)
        {
            if(role == null) throw new ArgumentNullException(nameof(role));

            try
            {
                await this._role.UpdateAsync(role);

            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return role;
        }

        public async Task<Role> GetRole(int id)
        {
            if(id <= 0) throw new ArgumentNullException(nameof(id));

            Role  role = null;

            try
            {
                role = await this._role.FindByIdAsync(id.ToString());

            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return role;
        }

        public async Task<Role> RemoveRole(Role role)
        {
            if(role == null) throw new ArgumentNullException(nameof(role));

            try
            {
                await this._role.DeleteAsync(role);

            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return role;
        }

        public async Task<IList<Role>> Roles()
        {
            IList<Role> roles = new List<Role>();

            try
            {
                roles = this._role.Roles.ToList();
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return roles;
        }
    }
}