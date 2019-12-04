using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OnlineExamApp.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _dbContext;
        public CategoryRepository(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<IEnumerable<ICategory>> GetCateogory()
        {
            try
            {
                var result = await (from d in _dbContext.Categories
                                    select new Model.Category
                                    {
                                        CategoryId = d.CategoryId,
                                        CategoryName = d.CategoryName,
                                        DigitalId = d.DigitalId,
                                        DateCreated = d.DateCreated,
                                        Duration = d.Duration
                                    }

                ).OrderByDescending(p => p.CategoryId).ToListAsync();

                return result;
            }
            catch (Exception e)
            {
                throw new ApplicationException("QuestionRepository from GetQuestionsByCaregoryId", e);
            }
        }
    }
}