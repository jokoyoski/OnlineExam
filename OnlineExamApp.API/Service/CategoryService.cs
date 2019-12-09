using System;
using System.Threading.Tasks;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public async Task<string> ProcessSaveCategory(ICategory category)
        {

            if(category == null) throw new ArgumentNullException(nameof(category));

            bool isDataOkay = (this._categoryRepository.GetCateogoryByName(category.CategoryName) == null) ? true : false;

            if(!isDataOkay)
            {
                return "Category is already exist";
            }
            
            return await this._categoryRepository.SaveCategory(category);
        }
        public async Task<string> ProcessEditCategory(ICategory category)
        {

            if(category == null) throw new ArgumentNullException(nameof(category));

            return await this._categoryRepository.EditCategory(category);
        }
        public async Task<string> ProcessDeleteCategory(int categoryId)
        {
            if(categoryId <= 0) throw new ArgumentNullException(nameof(categoryId));

            return await this._categoryRepository.DeleteCategory(categoryId);
        }

    }
}