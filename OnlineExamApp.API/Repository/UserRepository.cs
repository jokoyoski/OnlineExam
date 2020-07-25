using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ICoreRepository<User, int> _coreRepository;
        private readonly ILogger<UserRepository> _logger;

        public UserRepository(ICoreRepository<User, int> coreRepository, ILogger<UserRepository> logger)
        {
            _coreRepository = coreRepository;
            _logger = logger;
        }

        public async Task<User> GetUserById(int userId)
        {
            _logger.LogDebug($"Getting {typeof(User).FullName} with id {userId}");

            var result =  _coreRepository.Get(userId);
            
            return result;
        }
    }
}