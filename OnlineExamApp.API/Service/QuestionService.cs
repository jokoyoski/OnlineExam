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
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

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
        private readonly IAppSettingsService _appSettings;
        private readonly UserManager<User> _userManager;

        public QuestionService(IQuestionRepository questionRepository, UserManager<User> userManager,
        IOptionRepository optionRepository, IMapper mapper, IUserScoreRepository userScoreRepository,
        ICategoryRepository categoryRepository, IDigitalFileRepository digitalFileRepository,
        IScoreRepository scoreRepository, IEmailService emailService, ICacheService cacheService, IAppSettingsService appSettings)
        {
            this._digitalFileRepository = digitalFileRepository;
            this._scoreRepository = scoreRepository;
            this._emailService = emailService;
            this._cacheService = cacheService;
            this._appSettings = appSettings;
            this._categoryRepository = categoryRepository;
            this._userScoreRepository = userScoreRepository;
            this._mapper = mapper;
            this._optionRepository = optionRepository;
            this._questionRepository = questionRepository;
            this._userManager = userManager;
        }

        public async Task<string> AddOption(IOption option)
        {

            if (option == null) return $"{option} is null";

            var qtn = await _optionRepository.AddOption(option);

            if (qtn == null) return $"Option not added Successfull";

            return string.Empty;
        }

        public async Task<string> AddQuestion(IQuestion question)
        {

            if (question == null) return $"{question} is null";

            var qtn = await _questionRepository.AddQuestion(question);

            if (qtn == null) return $"Question not added successfully";

            return string.Empty;
        }

        public async Task<string> DeleteOption(IOption option)
        {

            if (option == null) return $"{option} is null";

            var qtn = await _optionRepository.DeleteOption(option);

            if (qtn == null) return $"Option not deleted successfully";

            return string.Empty;
        }

        public async Task<string> DeleteQuestion(IQuestion question)
        {
            if (question == null) return $"{question} is null";

            var qtn = await _questionRepository.RemoveQuestion(question);

            if (qtn == null) return $"Question not deleted successfully";

            return string.Empty;
        }

        public async Task<string> EditOption(IOption option)
        {
            if (option == null) return $"{option} is null";

            var qtn = await _optionRepository.UpdateOption(option);

            if (qtn == null) return $"Option not edited successfully";

            return string.Empty;
        }

        public async Task<string> EditQuestion(IQuestion question)
        {
            if (question == null) return $"{question} is null";

            var qtn = await _questionRepository.UpdateQuestion(question);

            if (qtn == null) return $"Question not edited successfully";

            return string.Empty;
        }

        public async Task<IEnumerable<ICategoryForDisplayDto>> GetCategories()
        {
            var categoryCollection = _cacheService.Get<IEnumerable<ICategory>>("::category::");

            if (categoryCollection == null)
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

        public async Task<List<QuestionOptionDto>> GetQuestion(int categoryId)
        {
            if (categoryId <= 0) throw new ArgumentNullException(nameof(categoryId));

            var questions = await _questionRepository.GetQuestionsByCaregoryId(categoryId);

            if (questions == null) throw new NullReferenceException(nameof(questions));

            var questionOptions = new List<QuestionOptionDto>();

            foreach (var qtn in questions)
            {
                var questionOption = new QuestionOptionDto();

                questionOption.Question = qtn;

                questionOption.Options = new List<IOption>();

                var options = await _optionRepository.GetOptionsByQuestionId(qtn.QuestionId);

                if (options == null) throw new NullReferenceException(nameof(options));

                foreach (var item in options)
                {
                    questionOption.Options.Add(item);
                }
                questionOptions.Add(questionOption);

            }

            return questionOptions;
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

            if (userInfo.Trials > 0) n = questionCollection.Count;

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
                    displayModel.Trials = userInfo.Trials;
                }
            }
            else
            {
                randomSpecificList = questionCollection.GetRange(0, questionCollection.Count);

                if (userInfo != null && userInfo.Trials > 0)
                {

                    var successful = await this._userManager.UpdateAsync(userInfo);
                    if (successful.Succeeded)
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

            if (userScoreHistory == null)
            {
                result.ReturnMessage = await this._scoreRepository.SaveScoreHistory(presentScore);
                if (!string.IsNullOrEmpty(result.ReturnMessage)) return result;
            }

            else if (userScoreHistory != null && userScoreHistory.Value < score)
            {
                presentScore.ScoreId = userScoreHistory.ScoreId;
                result.ReturnMessage = await this._scoreRepository.UpdateScoreHistory(presentScore);
                if (!string.IsNullOrEmpty(result.ReturnMessage)) return result;
            }

            var highScoresCollections = await this._scoreRepository.GetScoresCollectionByCategoryId(categoryId);

            if (highScoresCollections != null)
            {
                var scorePosition = highScoresCollections.Where(p => p.UserId.Equals(userId)).SingleOrDefault();

                var count = 0;

                foreach (var item in highScoresCollections)
                {
                    var user = await this._userManager.FindByIdAsync(item.UserId.ToString());
                    item.Username = user.UserName;
                    var category = await this._categoryRepository.GetCateogoryByCategoryId(item.CategoryId);
                    item.CategoryName = category.CategoryName;
                    count++;
                    if (item.UserId == userId)
                    {

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

            --userInfo.Trials;
            var successful = await this._userManager.UpdateAsync(userInfo);

            result.Trials = userInfo.Trials;

            _emailService._toEmail = userInfo.Email;
            _emailService._toName = userInfo.LastName + " " + userInfo.FirstName;

            _ = await _emailService.Execute(EmailType.ScoreDetail);

            return result;
        }

        public async Task<string> SaveQuestion(IUploadQuestionDto file)
        {
            string result = string.Empty;
            int categoryId = file.CategoryId;

            if (file.File == null) return "No Uploaded file";

            Stream pdf = file.File.OpenReadStream();

            if (pdf == null) return "Invalid file";

            try
            {
                var questionResponse = new QuestionRipperResponse();

                using (HttpClient client = new HttpClient())
                {

                    client.BaseAddress = new Uri(await _appSettings.QuestionRipperUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("TerminalId", await _appSettings.TerminalId);

                    var filepath = file.File;
                    string filename = file.File.FileName;

                    MultipartFormDataContent content = new MultipartFormDataContent();
                    ByteArrayContent fileContent = new ByteArrayContent(pdf.StreamToByteArray());

                    //fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = filename };

                    content.Headers.Add("TerminalId", await _appSettings.TerminalId);
                    
                    //content.Add(fileContent,"File");

                    content.Add(fileContent, "file", file.File.FileName);

                    //content.Add(fileContent);

                    HttpResponseMessage response = await client.PostAsync("/api/product/pdf", content);

                    var resp = await response.Content.ReadAsStringAsync();

                    questionResponse = JsonConvert.DeserializeObject<QuestionRipperResponse>(resp);
                }

                if (questionResponse == null || !questionResponse.ResponseCode.Equals("00")) return "Request Failed";

                result = await SaveQuestionHelper(questionResponse.Questions, categoryId);

                return result;
            }
            catch (Exception e)
            {
                return $"{e.Message}";
            }
        }

        private async Task<string> SaveQuestionHelper(List<QuestionObject> questions, int categoryId)
        {
            string result = string.Empty;

            if (questions == null || !questions.Any()) return "No question exist";

            foreach (var question in questions)
            {
                if (question.isQuestionValid)
                {
                    IQuestion questionModel = new Question
                    {
                        Questions = question.Question,
                        CategoryId = categoryId,
                        DateCreated = DateTime.UtcNow
                    };


                    var response = await this._questionRepository.SaveQuestion(questionModel);

                    if (response != null && response.QuestionId > 0)
                    {
                        foreach (var option in question.Options)
                        {
                            IOption questionOption = new Option
                            {
                                QuestionId = response.QuestionId,
                                OptionName = option.Option,
                                DateCreated = DateTime.UtcNow
                            };

                            _ = await this._optionRepository.SaveQuestionOption(questionOption);
                        }
                    }
                }
            }
            return result;
        }
  
    }

    public static class ExtensionMethodHelper
    {
        public static byte[] StreamToByteArray(this Stream inputStream)
        {
            byte[] bytes = new byte[16384];
            using (MemoryStream memoryStream = new MemoryStream())
            {
                int count;
                while ((count = inputStream.Read(bytes, 0, bytes.Length)) > 0)
                {
                    memoryStream.Write(bytes, 0, count);
                }
                return memoryStream.ToArray();
            }
        }

    }
}