using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineExamApp.API.Dto;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Service
{
    public class UserService : IUserService
    {
        private readonly IUserScoreRepository _userScoreRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;

        public UserService(IUserScoreRepository userScoreRepository, ICategoryRepository categoryRepository, IUserRepository userRepository)
        {
            this._categoryRepository = categoryRepository;
            this._userRepository = userRepository;
            this._userScoreRepository = userScoreRepository;
        }
        public async Task<IPerformanceDisplayDto> GetUserPerformanceByCatetgory(int userId, int categoryId)
        {

            if (userId <= 0) throw new ArgumentNullException(nameof(userId));

            if (categoryId <= 0) throw new ArgumentNullException(nameof(categoryId));

            decimal averageScoreUser = 0;
            decimal averageScoreOverall = 0;

            //get all the user score for a specific category
            IEnumerable<IUserScore> usersScoreCollectionByUserIdAndCategoryId = await this._userScoreRepository.GetUserScoresByUserIdAndCategoryId(userId, categoryId);

            if (usersScoreCollectionByUserIdAndCategoryId != null && usersScoreCollectionByUserIdAndCategoryId.Count() > 0)
            {
                //getting just the score value from the above list
                decimal[] scoreUser = usersScoreCollectionByUserIdAndCategoryId.ToList().Select(p => p.Score).ToArray();
                //get the average user score from extension method
                averageScoreUser = scoreUser.Average();
            }

            //get all the scores for a category
            IEnumerable<IUserScore> usersScoreCollectionByCategoryId = await this._userScoreRepository.GetUserScoresByCategoryId(categoryId);

            if (usersScoreCollectionByCategoryId != null && usersScoreCollectionByCategoryId.Count() > 0)
            {
                //getting just the score value from the above list
                decimal[] scoreOverall = usersScoreCollectionByCategoryId.ToList().Select(p => p.Score).ToArray();
                //get the average user score from extension method
                averageScoreOverall = scoreOverall.Average();
            }



            IPerformanceDisplayDto performanceDisplayDto = new PerformanceDisplayDto();

            performanceDisplayDto.UserAverageScore = new Chat();
            performanceDisplayDto.OverallAverageScore = new Chat();

            //Passing user value
            performanceDisplayDto.UserAverageScore.Label = "User Performance";
            performanceDisplayDto.UserAverageScore.Data = new decimal[1];
            performanceDisplayDto.UserAverageScore.Data[0] = Math.Round(averageScoreUser, 1);

            //Passing user value
            performanceDisplayDto.OverallAverageScore.Label = "Overall Performance";
            performanceDisplayDto.OverallAverageScore.Data = new decimal[1];
            performanceDisplayDto.OverallAverageScore.Data[0] = Math.Round(averageScoreOverall, 1);

            return performanceDisplayDto;
        }


        public async Task<User> GetUserById(int id)
        {   
            if(id <= 0) throw new ArgumentNullException(nameof(id));

            return await _userRepository.GetUserById(id);
        }
    }


}