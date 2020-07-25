using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface ICoreRepository<T, in TIdT>
    {
        T Get(TIdT id); 
    }
}