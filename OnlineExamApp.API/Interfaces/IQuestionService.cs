using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineExamApp.API.Dto;

namespace OnlineExamApp.API.Interfaces
{
    public interface IQuestionService
    {
        Task<IEnumerable<ICategoryForDisplayDto>> GetCategories();
         Task<IEnumerable<IQuestionForDisplay>> GetQuestionListForDislay(string username, int categoryId);
         Task<IProcessAnswerReturnDto> ProcessAnweredQuestions(int userId, List<AnweredQuestionDto> anweredQuestion);
         
    }
}