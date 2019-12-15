using System.Collections.Generic;

namespace OnlineExamApp.API.Interfaces
{
    public interface IQuestionsForDisplayDto
    {
        int Trials { get; set; }
        IEnumerable<IQuestionForDisplay> QuestionsCollections { get; set; }
    }
}