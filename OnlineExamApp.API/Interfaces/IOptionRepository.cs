using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IOptionRepository
    {
         Task<IEnumerable<IOption>> GetOptionsByQuestionId(int questionId);
         Task<IEnumerable<IOption>> GetCorrectOptionByQuestionId(int questionId);
    }
}