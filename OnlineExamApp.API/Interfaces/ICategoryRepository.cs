using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface ICategoryRepository
    {
        Task<ICategory> GetCateogoryByCategoryId(int categoryId);
        Task<IEnumerable<ICategory>> GetCateogory();
    }
}