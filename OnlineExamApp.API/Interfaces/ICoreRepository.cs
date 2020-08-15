using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface ICoreRepository<T, in TIdT>
    {
        Task<List<T>> GetAll();
        Task<List<T>> GetAll(TIdT id);
        Task<List<T>> GetAll(int page, int limit); 
        Task<T> Get(TIdT id);
        Task<T> Add(T t);
        Task<T> Update(T t);
        Task<T> Remove(T t);
        
    }
}