using AutoMapper;
using Newtonsoft.Json;
using OnlineExamApp.API.Dto;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace OnlineExamApp.API.Service
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IOptionRepository _optionRepository;
        private readonly IMapper _mapper;
        private readonly IUserScoreRepository _userScoreRepository;
        private readonly ICategoryRepository _categoryRepository;

        public QuestionService(IQuestionRepository questionRepository,
        IOptionRepository optionRepository, IMapper mapper, IUserScoreRepository userScoreRepository,
        ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
            this._userScoreRepository = userScoreRepository;
            this._mapper = mapper;
            this._optionRepository = optionRepository;
            this._questionRepository = questionRepository;
        }
        public async Task<IEnumerable<ICategory>> GetCategories()
        {
            var categoryCollection = await this._categoryRepository.GetCateogory();

            return categoryCollection;
        }
        public async Task<IEnumerable<IQuestionForDisplay>> GetQuestionListForDislay(int categoryId)
        {
            if (categoryId <= 0) throw new ArgumentNullException(nameof(categoryId));

            var questionList = await this._questionRepository.GetQuestionsByCaregoryId(categoryId);

            var category = await this._categoryRepository.GetCateogoryByCategoryId(categoryId);

            var questionCollection = _mapper.Map<IEnumerable<IQuestionForDisplay>>(questionList).ToList();

            Random rand = new Random();

            int n = questionCollection.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                var value = questionCollection[k];
                questionCollection[k] = questionCollection[n];
                questionCollection[n] = value;
            }

            var randomSpecificList = new List<IQuestionForDisplay>();

            if (category != null && category.NumberofQueston > 0)
            {
                randomSpecificList = questionCollection.GetRange(0, category.NumberofQueston);
            }
            else
            {
                randomSpecificList = questionCollection.GetRange(0, 2);
            }


            foreach (var options in randomSpecificList)
            {

                var optionCollection = await this._optionRepository.GetOptionsByQuestionId(options.QuestionId);

                options.Options = _mapper.Map<IEnumerable<IOptionsForDisplay>>(optionCollection);
            }

            return randomSpecificList;
        }
        public async Task<IProcessAnswerReturnDto> ProcessAnweredQuestions(int userId, IList<IAnweredQuestionDto> anweredQuestion)
        {

            if (anweredQuestion == null) throw new ArgumentNullException(nameof(anweredQuestion));

            decimal score = 0;
            int categoryId = 0;

            IProcessAnswerReturnDto result = new ProcessAnswerReturnDto();

            foreach (var answers in anweredQuestion)
            {
                var correctOptionCollection = await this._optionRepository.GetCorrectOptionByQuestionId(answers.QuestionId);

                foreach (var answer in answers.Options)
                {
                    foreach (var correctAnswer in correctOptionCollection)
                    {
                        if (answer.OptionId == correctAnswer.OptionId) score++;
                    }
                }
                categoryId = answers.CategoryId;
            }

            result.Score = score;

            IUserScore userScore = new UserScore
            {
                Score = score,
                UserId = userId,
                CategoryId = categoryId,
                DateCreated = DateTime.UtcNow,
                DateTaken = DateTime.UtcNow
            };

            if (!string.IsNullOrEmpty(await this._userScoreRepository.SaveUserScore(userScore)))
            {
                result.ReturnMessage = await this._userScoreRepository.SaveUserScore(userScore);
            }

            return result;
        }

    }
}