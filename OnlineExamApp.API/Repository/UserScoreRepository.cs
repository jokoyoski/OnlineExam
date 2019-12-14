using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Repository
{
    public class UserScoreRepository : IUserScoreRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public UserScoreRepository(DataContext dataContext, IMapper mapper)
        {
            this._mapper = mapper;
            this._dataContext = dataContext;
        }
        public async Task<IEnumerable<IUserScore>> GetUserScoresByUserId(int userId)
        {
            try{

                var result =  this._dataContext.UserScores
                    //.Where(p=>p.UserId.Equals(userId))
                    .OrderByDescending(p => p.CategoryId).AsQueryable();

                return result;

            }catch (Exception e)
            {
                throw new ArgumentNullException("GetUserScoresByUserId in UserScoreRepository", e);
            }
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
                result = string.Format("SaveUserScore - {0}, {1}", e.Message,
                e.InnerException != null ? e.InnerException.Message : "");
            }
            return result;
        }
    }
}