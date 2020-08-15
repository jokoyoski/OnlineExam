using Microsoft.AspNetCore.Http;
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
    public class QuestionRepository : IQuestionRepository
    {
        private readonly DataContext _dbContext;
        private readonly ILogger<QuestionRepository> _logger;

        public QuestionRepository(DataContext dbContext, ILogger<QuestionRepository> logger)
        {
            this._dbContext = dbContext;
            this._logger = logger;
        }

        public async Task<IQuestion> AddQuestion(IQuestion question)
        {
            if (question == null) throw new ArgumentNullException(nameof(question));

            try
            {
                await this._dbContext.Questions.AddAsync(question as Question);
                await this._dbContext.SaveChangesAsync();

            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return question;
        }

        public async Task<IEnumerable<IQuestion>> GetQuestionsByCaregoryId(int categoryId)
        {
            var result = new List<Question>();
            try
            {
                result = await this._dbContext.Questions.Where(p=>p.CategoryId.Equals(categoryId)).ToListAsync();

                return result;
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return result;

        }

        public async Task<IQuestion> RemoveQuestion(IQuestion question)
        {
             if (question == null) throw new ArgumentNullException(nameof(question));

            try
            {
                this._dbContext.Questions.Remove(question as Question);
                await this._dbContext.SaveChangesAsync();
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return question;
        }

        public async Task<IQuestion> SaveQuestion(IQuestion question)
        {
            if (question == null) throw new ArgumentNullException(nameof(question));

            try
            {
                await this._dbContext.Questions.AddAsync(question as Question);
                await this._dbContext.SaveChangesAsync();
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return question;
        }

        public async Task<IQuestion> UpdateQuestion(IQuestion question)
        {
            if (question == null) throw new ArgumentNullException(nameof(question));

            try
            {
                this._dbContext.Questions.Update(question as Question);
                await this._dbContext.SaveChangesAsync();
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }


            return question;
        }
    }
}
