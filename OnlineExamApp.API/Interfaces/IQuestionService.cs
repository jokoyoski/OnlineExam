using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IQuestionService
    {
         Task<IEnumerable<IQuestionForDisplay>> GetQuestionListForDislay(int categoryId);
    }
}