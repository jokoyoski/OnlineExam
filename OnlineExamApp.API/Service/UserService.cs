using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineExamApp.API.Dto;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Service
{
    public class UserService : IUserService
    {
        private readonly IUserScoreRepository _userScoreRepository;
        private readonly ICategoryRepository _categoryRepository;
        public UserService(IUserScoreRepository userScoreRepository, ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
            this._userScoreRepository = userScoreRepository;
        }
        public async Task<IUserScoreForDisplayDto> GetUserScoreByUserId(int userId)
        {

            if (userId <= 0) throw new ArgumentNullException(nameof(userId));

            IEnumerable<IUserScore> usersScoreCollectionByUser = await this._userScoreRepository.GetUserScoresByUserId(userId);

            IUserScoreForDisplayDto returnModel = new UserScoreForDisplayDto();
            returnModel.CategoryScoreCollection = new List<ICategoryScore>();


            if (usersScoreCollectionByUser != null)
            {
                returnModel.UserId = userId;

                IEnumerable<ICategory> category = await this._categoryRepository.GetCateogory();


                foreach (var pack in category)
                {
                    ICategoryScore categoryScore = new CategoryScore();

                    int count = 0;
                    decimal totalScore = 0;

                    foreach (var item in usersScoreCollectionByUser)
                    {
                        if (pack.CategoryId == item.CategoryId)
                        {
                            totalScore += item.Score;
                            count++;
                        }
                    }
                    if (count > 0 && totalScore > 0)
                    {
                        decimal averageScore = totalScore / count;
                        decimal percentageAverage = (averageScore / pack.NumberofQueston) * 100;
                        categoryScore.PercentageAverageScore = percentageAverage / 100;
                    }
                    categoryScore.CategoryName = pack.CategoryName;
                    returnModel.CategoryScoreCollection.Add(categoryScore);
                }

            }
            return returnModel;
        }
    }
}