using System;
using System.Threading.Tasks;
using AutoMapper;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Repository
{
    public class UserScoreRepository : IUserScoreRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public UserScoreRepository(DataContext dataContext, IMapper mapper)
        {
            this._mapper = mapper;
            this._dataContext = dataContext;
        }

        public async Task<string> SaveUserScore(IUserScore userScore)
        {

            if (userScore == null) throw new ArgumentNullException(nameof(userScore));

            string result = string.Empty;

            var newUserScore = this._mapper.Map<UserScore>(userScore);

            try
            {
                await this._dataContext.UserScores.AddAsync(newUserScore);
                await this._dataContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                result = string.Format("SaveUserScore - {0}, {1}", e.Message,
                e.InnerException != null ? e.InnerException.Message : "");
            }
            return result;
        }
    }
}