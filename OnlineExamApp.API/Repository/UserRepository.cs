using System;
using System.Linq;
using System.Threading.Tasks;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dbContext;
        public UserRepository(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }

        
        
    }
}