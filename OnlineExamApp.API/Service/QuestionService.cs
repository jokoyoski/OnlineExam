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
using Microsoft.AspNetCore.Identity;
using static OnlineExamApp.API.Service.EmailService;

namespace OnlineExamApp.API.Service
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IOptionRepository _optionRepository;
        private readonly IMapper _mapper;
        private readonly IUserScoreRepository _userScoreRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDigitalFileRepository _digitalFileRepository;
        private readonly IScoreRepository _scoreRepository;
        private readonly IEmailService _emailService;
        private readonly ICacheService _cacheService;
        private readonly UserManager<User> _userManager;
        public QuestionService(IQuestionRepository questionRepository, UserManager<User> userManager,
        IOptionRepository optionRepository, IMapper mapper, IUserScoreRepository userScoreRepository,
        ICategoryRepository categoryRepository, IDigitalFileRepository digitalFileRepository,
        IScoreRepository scoreRepository, IEmailService emailService, ICacheService cacheService)
        {
            this._digitalFileRepository = digitalFileRepository;
            this._scoreRepository = scoreRepository;
            this._emailService = emailService;
            this._cacheService = cacheService;
            this._categoryRepository = categoryRepository;
            this._userScoreRepository = userScoreRepository;
            this._mapper = mapper;
            this._optionRepository = optionRepository;
            this._questionRepository = questionRepository;
            this._userManager = userManager;
        }
        public async Task<IEnumerable<ICategoryForDisplayDto>> GetCategories()
        {
            var categoryCollection = _cacheService.Get<IEnumerable<ICategory>>("::category::");

            if(categoryCollection == null) 
            {
                categoryCollection = await this._categoryRepository.GetCateogory();
                _cacheService.Add<IEnumerable<ICategory>>("::category::", categoryCollection);
            }

            var categoryForDisplayDto = _mapper.Map<IEnumerable<ICategoryForDisplayDto>>(categoryCollection).ToList();

            foreach (var d in categoryForDisplayDto)
            {
                var model = await this._digitalFileRepository.GetPhotoById(d.PhotoId);
                if (model != null) d.PhotoUrl = model.Url;
            }

            return categoryForDisplayDto;
        }
        
        public async Task<IQuestionsForDisplayDto> GetQuestionListForDislay(int userId, int categoryId)
        {

            if (userId <= 0) throw new ArgumentNullException(nameof(userId));

            if (categoryId <= 0) throw new ArgumentNullException(nameof(categoryId));


            var userInfo = await this._userManager.FindByIdAsync(userId.ToString());


            var questionList = await this._questionRepository.GetQuestionsByCaregoryId(categoryId);

            var category = await this._categoryRepository.GetCateogoryByCategoryId(categoryId);

            var questionCollection = _mapper.Map<IEnumerable<IQuestionForDisplay>>(questionList).ToList();

            Random rand = new Random();

            int n = 0;

            if(userInfo.Trials > 0) n = questionCollection.Count;

            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                var value = questionCollection[k];
                questionCollection[k] = questionCollection[n];
                questionCollection[n] = value;
            }

            var displayModel = new QuestionsForDisplayDto();

            var randomSpecificList = new List<IQuestionForDisplay>();
            if (category != null && category.NumberofQueston > 0 && category.NumberofQueston <= questionCollection.Count)
            {
                randomSpecificList = questionCollection.GetRange(0, category.NumberofQueston);

                if (userInfo != null && userInfo.Trials > 0)
                {
                    --userInfo.Trials;
                    var successful = await this._userManager.UpdateAsync(userInfo);
                    if(successful.Succeeded)
                    {
                        displayModel.Trials = userInfo.Trials;
                    }
                }
            }
            else
            {
                randomSpecificList = questionCollection.GetRange(0, questionCollection.Count);

                if (userInfo != null && userInfo.Trials > 0)
                {
                    --userInfo.Trials;
                    var successful = await this._userManager.UpdateAsync(userInfo);
                    if(successful.Succeeded)
                    {
                        displayModel.Trials = userInfo.Trials;
                    }
                    
                }
            }

            foreach (var options in randomSpecificList)
            {

                var optionCollection = await this._optionRepository.GetOptionsByQuestionId(options.QuestionId);

                options.Options = _mapper.Map<IEnumerable<IOptionsForDisplay>>(optionCollection);
            }

            displayModel.QuestionsCollections = randomSpecificList;

            return displayModel;
        }
        
        public async Task<IProcessAnswerReturnDto> ProcessAnweredQuestions(int userId, List<AnweredQuestionDto> anweredQuestion)
        {

            if (anweredQuestion == null) throw new ArgumentNullException(nameof(anweredQuestion));

            decimal score = 0;
            int categoryId = 0;

            IProcessAnswerReturnDto result = new ProcessAnswerReturnDto();

            foreach (var answers in anweredQuestion)
            {
                var correctOptionCollection = await this._optionRepository.GetCorrectOptionByQuestionId(answers.QuestionId);

                foreach (var correctAnswer in correctOptionCollection)
                {
                    if (answers.OptionId == correctAnswer.OptionId) score++;
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

            var output = await this._userScoreRepository.SaveUserScore(userScore);

            if (!string.IsNullOrEmpty(output))
            {
                result.ReturnMessage = output;
            }

            var userScoreHistory = await this._scoreRepository.GetScoresByUserIdAndCategoryId(userId, categoryId);

            IScore presentScore = new Score
            {
                Value = score,
                CategoryId = categoryId,
                UserId = userId
            };

            if(userScoreHistory == null)
            {
                result.ReturnMessage = await this._scoreRepository.SaveScoreHistory(presentScore);
                if(!string.IsNullOrEmpty(result.ReturnMessage)) return result;
            }

            else if(userScoreHistory != null && userScoreHistory.Value < score)
            {
                presentScore.ScoreId = userScoreHistory.ScoreId;
                result.ReturnMessage = await this._scoreRepository.UpdateScoreHistory(presentScore);
                if(!string.IsNullOrEmpty(result.ReturnMessage)) return result;
            }

            var highScoresCollections = await this._scoreRepository.GetScoresCollectionByCategoryId(categoryId);
            
            if(highScoresCollections != null){
                var scorePosition = highScoresCollections.Where(p=>p.UserId.Equals(userId)).SingleOrDefault();

                var count = 0;

                foreach(var item in highScoresCollections){
                    var user = await this._userManager.FindByIdAsync(item.UserId.ToString());
                    item.Username = user.UserName;
                    var category = await this._categoryRepository.GetCateogoryByCategoryId(item.CategoryId);
                    item.CategoryName = category.CategoryName;
                    count++;
                    if(item.UserId == userId){
                        
                        break;
                    }

                }

                //Find how to pass position
                result.Position = count;
                //Total Number of Participant
                result.NoOfParticipant = highScoresCollections.Count();
                //Whats my hghestScore
                result.HighestScore = scorePosition.Value;
                //Select First Five
                result.ScoreBoardCollection = highScoresCollections.Take(5).ToList();
            }
            
            var userInfo = await this._userManager.FindByIdAsync(userId.ToString());

            result.Trials = userInfo.Trials;

            _emailService._toEmail = userInfo.Email;
            _emailService._toName = userInfo.LastName + " " + userInfo.FirstName;

            _ = await _emailService.Execute(EmailType.ScoreDetail);

            return result;
        }
    }
}