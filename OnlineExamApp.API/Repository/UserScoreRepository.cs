using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;
using Microsoft.Extensions.Logging;

namespace OnlineExamApp.API.Repository
{
    public class UserScoreRepository : IUserScoreRepository
    {
        private readonly DataContext _dataContext;
        private readonly ILogger<UserScore> _logger;
        public UserScoreRepository(DataContext dataContext, ILogger<UserScore> logger)
        {
            this._dataContext = dataContext;
            this._logger = logger;
        }
        
        public async Task<IEnumerable<IUserScore>> GetUserScoresByUserId(int userId)
        {
            var userScore = new List<UserScore>();

            try{

                userScore =  await this._dataContext.UserScores
                    .Where(p=>p.UserId.Equals(userId))
                    .OrderByDescending(p => p.CategoryId).ToListAsync();

            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return userScore;
            
        }

        public async Task<IEnumerable<IUserScore>> GetUserScoresByUserIdAndCategoryId(int userId, int categoryId)
        {
            var userScore = new List<UserScore>();

            try{

                userScore = await this._dataContext.UserScores
                    .Where(p=>p.UserId.Equals(userId) && p.CategoryId.Equals(categoryId))
                    .OrderByDescending(p => p.CategoryId).ToListAsync();

            }
             catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return userScore;
        }

        public async Task<IEnumerable<IUserScore>> GetUserScoresByCategoryId(int categoryId)
        {
            if(categoryId <= 0) throw new ArgumentNullException(nameof(categoryId));

            var userscores = new List<UserScore>();

            try{

                userscores = await  this._dataContext.UserScores
                    .Where(p=>p.CategoryId.Equals(categoryId))
                    .OrderByDescending(p => p.CategoryId).ToListAsync();

                

            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return userscores;
        }

        public async Task<string> SaveUserScore(IUserScore userScore)
        {

            if (userScore == null) throw new ArgumentNullException(nameof(userScore));

            string result = string.Empty;

            var newUserScore = new UserScore{
                UserId = userScore.UserId,
                Score = userScore.Score,
                CategoryId = userScore.CategoryId,
                DateCreated = DateTime.UtcNow,
                DateTaken = DateTime.Now,
            };

            try
            {
                await this._dataContext.UserScores.AddAsync(newUserScore);
                await this._dataContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                result = $"{e.Message}";
            }

            return result;
        }
    }
}