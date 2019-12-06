using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OnlineExamApp.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Repository
{
    public class DigitalFileRepository : IDigitalFileRepository
    {
        private readonly DataContext _dataContext;
        public DigitalFileRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<IPhoto> GetPhotoById(int photoId)
        {
            try{
                var result = await (from d in _dataContext.Photos 
                            where d.Id.Equals(photoId)
                          select new  Model.Photo{
                              

                          }).SingleOrDefaultAsync();

                return result;
            }catch(Exception e){
                throw new ApplicationException("QuestionRepository from GetQuestionsByCaregoryId", e);
            }
        }
    }
}