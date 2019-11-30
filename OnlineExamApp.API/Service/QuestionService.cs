using AutoMapper;
using OnlineExamApp.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Service
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IOptionRepository _optionRepository;
        private readonly IMapper _mapper;
        public QuestionService(IQuestionRepository questionRepository,
        IOptionRepository optionRepository, IMapper mapper)
        {
            this._mapper = mapper;
            this._optionRepository = optionRepository;
            this._questionRepository = questionRepository;
        }
    public async Task<IEnumerable<IQuestionForDisplay>> GetQuestionListForDislay(int categoryId)
    {
        if (categoryId <= 0) throw new ArgumentNullException(nameof(categoryId));

        var questionList = await this._questionRepository.GetQuestionsByCaregoryId(categoryId);

        var questionCollection =  _mapper.Map<IEnumerable<IQuestionForDisplay>>(questionList);

        foreach(var options in questionCollection){

            var optionCollection = await this._optionRepository.GetOptionsByQuestionId(options.QuestionId);
            
            options.Options = _mapper.Map<IEnumerable<IOptionsForDisplay>>(optionCollection);
        }

        return questionCollection;
    }

}
}