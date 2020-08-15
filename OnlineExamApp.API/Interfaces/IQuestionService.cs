using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using OnlineExamApp.API.Dto;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IQuestionService
    {
        Task<IEnumerable<ICategoryForDisplayDto>> GetCategories();
        Task<IQuestionsForDisplayDto> GetQuestionListForDislay(int userId, int categoryId);
        Task<IProcessAnswerReturnDto> ProcessAnweredQuestions(int userId, List<AnweredQuestionDto> anweredQuestion);
        Task<string> SaveQuestion(IUploadQuestionDto formFile);
        Task<List<QuestionOptionDto>> GetQuestion(int categoryId);
        Task<string> AddQuestion(IQuestion question);
        Task<string> EditQuestion(IQuestion question);
        Task<string> DeleteQuestion(IQuestion question);
        Task<string> AddOption(IOption option);
        Task<string>  EditOption(IOption option);
        Task<string>  DeleteOption(IOption option);
    }
}