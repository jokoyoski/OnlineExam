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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _dbContext;
        private readonly ILogger<CategoryRepository> _logger;

        public CategoryRepository(DataContext dbContext, ILogger<CategoryRepository> logger)
        {
            this._dbContext = dbContext;
            this._logger = logger;
        }
        public async Task<ICategory> GetCateogoryByCategoryId(int categoryId)
        {
            var result = new Category();

            try
            {
                result = await this._dbContext.Categories.Where(p=>p.CategoryId.Equals(categoryId))
                            .SingleOrDefaultAsync();

                
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return result;
        }
        public async Task<ICategory> GetCateogoryByName(string categoryName)
        {
            var result = new Category();
            try
            {
                result = await this._dbContext.Categories.Where(p=>p.CategoryName.Equals(categoryName))
                                .SingleOrDefaultAsync();
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return result;
        }
        public async Task<IEnumerable<ICategory>> GetCateogory()
        {
            var result = new List<Category>();
            try
            {
                result = await this._dbContext.Categories
                    .OrderByDescending(p => p.CategoryId).ToListAsync();
                
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return result;
        }
        public async Task<string> SaveCategory(ICategory category)
        {

            if(category == null) throw new ArgumentNullException(nameof(category));

            string result = string.Empty;

            var newCategory = new Category
            {
                CategoryName = category.CategoryName,
                CategoryDescription = category.CategoryDescription,
                DateCreated = DateTime.UtcNow,
                Duration = category.Duration,
                NumberofQueston = category.NumberofQueston,
                PhotoId = category.PhotoId
            };

            try
            {
                await this._dbContext.Categories.AddAsync(newCategory);
                await this._dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return result;
        }
        public async Task<string> EditCategory(ICategory category)
        {

            if(category == null) throw new ArgumentNullException(nameof(category));

            string result = string.Empty;

            try
            {
                var model = await this._dbContext.Categories.SingleOrDefaultAsync(p=>p.CategoryId.Equals(category.CategoryId));

                model.CategoryName = category.CategoryName;
                model.CategoryDescription = category.CategoryDescription;
                model.Duration = category.Duration;
                model.NumberofQueston = category.NumberofQueston;
                model.PhotoId = category.PhotoId;
                model.DateModified = DateTime.UtcNow;

                await this._dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

            return result;
        }
        public async Task<string> DeleteCategory(int categoryId)
        {

            if(categoryId <= 0) throw new ArgumentNullException(nameof(categoryId));

            string result = string.Empty;

            try
            {
                var model = await this._dbContext.Categories.SingleOrDefaultAsync(p=>p.CategoryId.Equals(categoryId));
                
                this._dbContext.Categories.Remove(model);
                await this._dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            
            return result;
        }
    }
}