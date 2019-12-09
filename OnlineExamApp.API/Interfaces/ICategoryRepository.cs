using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface ICategoryRepository
    {
        Task<ICategory> GetCateogoryByCategoryId(int categoryId);
        Task<IEnumerable<ICategory>> GetCateogory();
        Task<ICategory> GetCateogoryByName(string categoryName);
        Task<string> SaveCategory(ICategory category);
        Task<string> EditCategory(ICategory category);
        Task<string> DeleteCategory(int categoryId);
    }
}