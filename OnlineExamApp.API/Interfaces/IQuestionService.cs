using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IQuestionService
    {
        Task<IEnumerable<ICategory>> GetCategories();
         Task<IEnumerable<IQuestionForDisplay>> GetQuestionListForDislay(int categoryId);
         Task<IProcessAnswerReturnDto> ProcessAnweredQuestions(int userId, IList<IAnweredQuestionDto> anweredQuestion);
         
    }
}