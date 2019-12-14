using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Repository
{
    public class ScoreRepository : IScoreRepository
    {
        private readonly DataContext _dataContext;
        public ScoreRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        public async Task<IScore> GetScoresByUserIdAndCategoryId(int userId, int categoryId)
        {
            try
            {

                var result = this._dataContext.Scores
                    .Where(p => p.UserId == userId && p.CategoryId == categoryId)
                    .FirstOrDefaultAsync();

                return await result;

            }
            catch (Exception e)
            {
                throw new ArgumentNullException("GetScoresByUserIdAndCategoryId in UserScoreRepository", e);
            }
        }
        public async Task<IEnumerable<IScore>> GetScoresCollectionByCategoryId(int categoryId)
        {
            try
            {

                var result = await this._dataContext.Scores
                    .Where(p => p.CategoryId.Equals(categoryId))
                    .OrderByDescending(p => p.Value).ToListAsync();

                return result;

            }
            catch (Exception e)
            {
                throw new ArgumentNullException("GetScoresCollectionByUserIdAndCategoryId in UserScoreRepository", e);
            }
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
            catch (Exception e)
            {
                result = string.Format("SaveScoreHistory - {0}, {1}", e.Message,
                            e.InnerException != null ? e.InnerException.Message : "");
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
            catch (Exception e)
            {
                result = string.Format("UpdateScoreHistory - {0}, {1}", e.Message,
                            e.InnerException != null ? e.InnerException.Message : "");
            }
            return result;
        }

    }
}