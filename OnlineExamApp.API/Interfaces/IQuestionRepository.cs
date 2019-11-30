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
        Task<string> SaveQuestion(IFormFile formFile);
    }
}
