using Microsoft.EntityFrameworkCore;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Repository
{
    public class SystemSettings : ISystemSettings
    {
        private readonly DataContext _dbContext;

        public SystemSettings(DataContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<IEnumerable<ISettings>> GetSetting()
        {
            try
            {
                var result = await this._dbContext.Settings
                .OrderByDescending(p => p.Id).ToListAsync();

                return result;
            }
            catch (Exception e)
            {
                throw new ApplicationException("Settings from GetSettings", e);
            }
        }
    }
}