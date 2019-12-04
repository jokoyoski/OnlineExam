using Microsoft.EntityFrameworkCore;
using OnlineExamApp.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Repository
{
    public class OptionRepository : IOptionRepository
    {
        private readonly DataContext _dbContext;
        public OptionRepository(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<IEnumerable<IOption>> GetOptionsByQuestionId(int questionId)
        {
            try{
                var result = await (from d in _dbContext.Options 
                            where d.QuestionId.Equals(questionId)
                          select new  Model.Option{
                              QuestionId = d.QuestionId,
                              OptionId = d.OptionId,
                              OptionName = d.OptionName,
                              DateCreated = d.DateCreated,
                              //DateModified = d.DateModified
                          }).OrderByDescending(p=>p.QuestionId).ToListAsync();

                return result;
            }catch(Exception e){
                throw new ApplicationException("QuestionRepository from GetQuestionsByCaregoryId", e);
            }
        }

        public async Task<IEnumerable<IOption>> GetCorrectOptionByQuestionId(int questionId)
        {
            try{
                var result = await (from d in _dbContext.Options 
                            where d.QuestionId.Equals(questionId) && d.IsCorrect.Equals(true)
                          select new  Model.Option{
                              QuestionId = d.QuestionId,
                              OptionId = d.OptionId,
                              OptionName = d.OptionName,
                              DateCreated = d.DateCreated,
                              //DateModified = d.DateModified,
                              IsCorrect = d.IsCorrect
                          }).OrderByDescending(p=>p.QuestionId).ToListAsync();

                return result;
            }catch(Exception e){
                throw new ApplicationException("QuestionRepository from GetQuestionsByCaregoryId", e);
            }
        }

    }
}