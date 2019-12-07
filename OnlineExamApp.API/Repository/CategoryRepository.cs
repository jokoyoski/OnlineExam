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

        public async Task<ICategory> GetCateogoryByCategoryId(int categoryId)
        {
            try
            {
                var result = await this._dbContext.Categories
                .Include(m=>m.Photo).SingleOrDefaultAsync();

                return result;
            }
            catch (Exception e)
            {
                throw new ApplicationException("QuestionRepository from GetCateogoryByCategoryId", e);
            }
        }

        public async Task<IEnumerable<ICategory>> GetCateogory()
        {
            try
            {
                var result = await this._dbContext.Categories.ToListAsync();

                return result;
            }
            catch (Exception e)
            {
                throw new ApplicationException("QuestionRepository from GetQuestionsByCaregoryId", e);
            }
        }
    }
}