using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface ICategoryRepository
    {
         Task<IEnumerable<ICategory>> GetCateogory();
    }
}