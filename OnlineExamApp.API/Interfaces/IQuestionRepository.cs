using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
   public  interface IQuestionRepository
    {
        Task<IEnumerable<IQuestion>> GetQuestionsByCaregoryId(int categoryId);
        Task<IQuestion> SaveQuestion(IQuestion question);
        Task<IQuestion> UpdateQuestion(IQuestion question);
        Task<IQuestion> RemoveQuestion(IQuestion question);
        Task<IQuestion> AddQuestion(IQuestion question);
    }
}
