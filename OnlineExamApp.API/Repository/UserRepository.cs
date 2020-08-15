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
    public class UserRepository : IUserRepository
    {
        private readonly ILogger<UserRepository> _logger;
        private readonly UserManager<User> _userManager;

        public UserRepository(ILogger<UserRepository> logger, UserManager<User> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<IUser> GetUserById(int userId)
        {
            _logger.LogDebug($"Getting {typeof(User).FullName} with id {userId}");

            if (userId <= 0) throw new ArgumentNullException(nameof(userId));

            var user = new User();

            try
            {
                user = await _userManager.FindByIdAsync(userId.ToString());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return user;
        }

        public async Task<string> Activate(IUser user)
        {
            string result = string.Empty;

            try
            {
                var response = await _userManager.SetLockoutEnabledAsync(user as User, false);

                if (!response.Succeeded)
                {
                    return $"Unable to unlock {user.FirstName}, Error: {response.Errors.FirstOrDefault().Description}";
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                result = e.Message;
            }

            return result;
        }

        public async Task<string> RemoveUser(IUser user)
        {
            _logger.LogDebug($"Deleting {user.FirstName}");

            if (user == null) return "User is null";

            string result = string.Empty;

            try
            {
                var response = await _userManager.DeleteAsync(user as User);

                if (!response.Succeeded) return $"Unable to remove {user.FirstName}";
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                result = e.Message;
            }

            return result;
        }

        public async Task<string> DeactivateUser(IUser user, int days = 30)
        {
            string result = string.Empty;

            var userModel = (User)user;
            

            try
            {
                await _userManager.SetLockoutEnabledAsync(userModel, true);

                await _userManager.SetLockoutEndDateAsync(user as User, DateTime.Today.AddDays(days));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                result = e.Message;
            }

            return result;
        }

        public async Task<string> AddUser(IUser user)
        {
            _logger.LogDebug($"Adding {user.FirstName}");

            if (user == null) return "User is null";

            string result = string.Empty;

            try
            {
                var response = await _userManager.CreateAsync(user as User);

                if (!response.Succeeded) return $"Unable to add {user.FirstName}";

                _logger.LogDebug($"Adding {user.FirstName} was successful");

            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                result = e.Message;
            }

            return result;
        }

        public async Task<string> EditUser(IUser user)
        {

            _logger.LogDebug($"Editing {user.FirstName}");

            if (user == null) return "User is null";

            string result = string.Empty;

            try
            {

                var response = await _userManager.UpdateAsync(user as User);

                if (!response.Succeeded) return $"Unable to remove {user.FirstName}";

                _logger.LogDebug($"Editing {user.FirstName} was successful");
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                result = e.Message;
            }

            return result;
        }

        public async Task<IList<User>> Users()
        {
            _logger.LogDebug($"Gatting all {typeof(User).FullName} out");
            var users = new List<User>();
            try
            {

                users = this._userManager.Users.ToList();

                _logger.LogDebug($"Getting all {typeof(User).FullName} was successful");
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }


            return users;
        }



        public async Task<string> AddUserToRole(User user, string role)
        {
            string result = string.Empty;

            var response = await _userManager.AddToRoleAsync(user, role);
            
            if(!response.Succeeded) return $"Adding {user.UserName} to {role} was not successful: Error {response.Errors.SingleOrDefault().ToString()}";

            return result;
        }

        public async Task<string> RemoveUserFromRole(User user, string role)
        {
            string result = string.Empty;;

            var response = await _userManager.RemoveFromRoleAsync(user, role);

            if(!response.Succeeded) return $"Removing {user.UserName} to {role} was not successful: Error {response.Errors.SingleOrDefault().ToString()}";

            return result;
        }

        public async Task<IList<string>> UserToRole(User user)
        {
            var response = await _userManager.GetRolesAsync(user);

            return response;
        }
    }
}