using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Repository
{
    public class DigitalFileRepository : IDigitalFileRepository
    {
        private readonly DataContext _dataContext;
        private readonly ILogger<DigitalFileRepository> _logger;

        public DigitalFileRepository(DataContext dataContext, ILogger<DigitalFileRepository> logger)
        {
            this._dataContext = dataContext;
            this._logger = logger;
        }

        public async Task<IPhoto> GetPhotoById(int photoId)
        {
            var photo = new Photo();
            try
            {
                photo = await this._dataContext.Photos.Where(d=>d.Id.Equals(photoId)).SingleOrDefaultAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return photo;
        }
    }
}