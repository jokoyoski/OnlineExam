using System.Collections.Generic;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{ 
    public class QuestionsForDisplayDto : IQuestionsForDisplayDto
    {
        public int Trials { get; set; }
        public IEnumerable<IQuestionForDisplay> QuestionsCollections { get; set; }
    }
}