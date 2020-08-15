using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Repository
{
    public class OptionRepository : IOptionRepository
    {
        private readonly DataContext _dbContext;
        private readonly ILogger<OptionRepository> _logger;

        public OptionRepository(DataContext dbContext, ILogger<OptionRepository> logger)
        {
            this._dbContext = dbContext;
            this._logger = logger;
        }

        public async Task<IEnumerable<IOption>> GetOptionsByQuestionId(int questionId)
        {
            var options = new List<Option>();

            try
            {
                options = await this._dbContext.Options.Where(p=>p.QuestionId.Equals(questionId)).ToListAsync();
            }
             catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return options;
        }

        public async Task<IEnumerable<IOption>> GetCorrectOptionByQuestionId(int questionId)
        {
            var result = new List<Option>();
            try
            {
                result = await (from d in _dbContext.Options 
                            where d.QuestionId.Equals(questionId) && d.IsCorrect.Equals(true)
                          select new  Model.Option{
                              QuestionId = d.QuestionId,
                              OptionId = d.OptionId,
                              OptionName = d.OptionName,
                              DateCreated = d.DateCreated,
                              //DateModified = d.DateModified,
                              IsCorrect = d.IsCorrect
                          }).OrderByDescending(p=>p.QuestionId).ToListAsync();

                
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return result;
        }

        public async Task<IOption> SaveQuestionOption(IOption option)
        {
            if(option == null)  throw new ArgumentNullException(nameof(option));

            try
            {
                await this._dbContext.Options.AddAsync(option as Option);
                await this._dbContext.SaveChangesAsync();
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }


            return option;
        }


        public async Task<IOption> AddOption(IOption option)
        {
            if(option == null)  throw new ArgumentNullException(nameof(option));

            try
            {
                await _dbContext.Options.AddAsync(option as Option);

                await _dbContext.SaveChangesAsync();
                
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return option;
        }

        public async Task<IOption> UpdateOption(IOption option)
        {
            if(option == null)  throw new ArgumentNullException(nameof(option));

            try
            {
                _dbContext.Options.Update(option as Option);
                await _dbContext.SaveChangesAsync();

                
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return option;
        }

        public async Task<IOption> DeleteOption(IOption option)
        {
            if(option == null)  throw new ArgumentNullException(nameof(option));

            try
            {
                _dbContext.Options.Remove(option as Option);
                await this._dbContext.SaveChangesAsync();
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return option;
        }

        
    }
}