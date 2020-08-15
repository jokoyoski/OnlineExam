using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;
using Microsoft.Extensions.Logging;
using OnlineExamApp.API.Dto;

namespace OnlineExamApp.API.Repository
{
    public class ScoreRepository : IScoreRepository
    {
        private readonly DataContext _dataContext;
        private readonly ILogger<ScoreRepository> _logger;

        public ScoreRepository(DataContext dataContext, ILogger<ScoreRepository> logger)
        {
            this._dataContext = dataContext;
            this._logger = logger;
        }
        public async Task<IScore> GetScoresByUserIdAndCategoryId(int userId, int categoryId)
        {
            var score  = new Score();
            try
            {

                score = await this._dataContext.Scores
                    .Where(p => p.UserId == userId && p.CategoryId == categoryId)
                    .FirstOrDefaultAsync();

                

            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return score;
        }
        public async Task<IEnumerable<IScoreDto>> GetScoresCollectionByCategoryId(int categoryId)
        {

            var scores = new List<ScoreDto>();
            try
            {

                scores = await (
                    from d in _dataContext.Scores
                    select new Dto.ScoreDto{
                        ScoreId = d.ScoreId,
                        Value = d.Value,
                        UserId = d.UserId,
                        CategoryId = d.CategoryId,
                        DateCreated = d.DateCreated,
                        DateModified = d.DateModified
                    }
                )
                    .Where(p => p.CategoryId.Equals(categoryId))
                    .OrderByDescending(p => p.Value).ToListAsync();

            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return scores;
        }
        public async Task<string> SaveScoreHistory(IScore score)
        {
            if (score == null) throw new ArgumentNullException(nameof(score));

            string result = string.Empty;

            var newRecored = new Score
            {
                Value = score.Value,
                UserId = score.UserId,
                CategoryId = score.CategoryId,
                DateCreated = DateTime.UtcNow
            };

            try
            {
                await this._dataContext.Scores.AddAsync(newRecored);
                await this._dataContext.SaveChangesAsync();
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return result;
        }
        public async Task<string> UpdateScoreHistory(IScore score)
        {
            if (score == null) throw new ArgumentNullException(nameof(score));

            string result = string.Empty;

            try
            {
                var model = await this._dataContext.Scores.Where(p => p.ScoreId.Equals(score.ScoreId))
                            .SingleOrDefaultAsync();

                model.Value = score.Value;
                model.DateModified = DateTime.UtcNow;

                await this._dataContext.SaveChangesAsync();
            }
            
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return result;
        }

    }
}