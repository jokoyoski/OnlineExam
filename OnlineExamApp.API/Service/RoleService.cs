using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            this._roleRepository = roleRepository;
        }


        public async Task<IList<Role>> Roles()
        {
            var result = await _roleRepository.Roles();

            return result; 
        }

        public async Task<Role> GetRole(int id)
        {
            if(id <= 0) throw new ArgumentNullException(nameof(id));

            var role = await _roleRepository.GetRole(id);

            return role;
        }

        public async Task<string> AddRole(Role role)
        {
            string result = string.Empty;

            if(role == null) return "Role is null";

            var response = await _roleRepository.AddRole(role);

            if(response == null) return $"Request not successfull";

            return result; 
        }

        public async Task<string> EditRole(Role role)
        {
            string result = string.Empty;

            if(role == null) return "Role is null";

            var response = await _roleRepository.EditRole(role);

            if(response == null) return $"Request not successfull";

            return result; 
        }


        public async Task<string> RemoveRole(Role role)
        {
            string result = string.Empty;

            if(role == null) return "Role is null";

            var response = await _roleRepository.RemoveRole(role);

            if(response == null) return $"Request not successfull";

            return result; 
        }


    }
}