using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Repository
{
    public class SystemSettingRepository : ISystemSettingRepository
    {
        private readonly DataContext _dbContext;
        private readonly ILogger<SystemSettingRepository> _logger;

        public SystemSettingRepository(DataContext dbContext, ILogger<SystemSettingRepository> logger)
        {
            this._dbContext = dbContext;
            this._logger = logger;
        }

        public async Task<IList<Setting>> GetSettings()
        {
            var settings = new List<Setting>();
            try
            {
                settings = this._dbContext.Settings.ToList();
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return settings;
        }
        
        public async Task<ISetting> GetSetting(int settingId)
        {
            if(settingId <= 0) throw new ArgumentNullException(nameof(settingId));

            var setting = new Setting();

            try
            {
                setting = await this._dbContext.Settings.FindAsync(settingId);
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return setting;
        }

        public async Task<ISetting> AddSetting(ISetting setting)
        {
            if(setting == null) throw new ArgumentNullException(nameof(setting));

            try
            {
                await this._dbContext.Settings.AddAsync(setting as Setting);
                await this._dbContext.SaveChangesAsync();
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return setting;
        }

         public async Task<ISetting> UpdateSetting(ISetting setting)
        {
            if(setting == null) throw new ArgumentNullException(nameof(setting));

            try
            {
                this._dbContext.Settings.Update(setting as Setting);
                await this._dbContext.SaveChangesAsync();
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return setting;
        }

         public async Task<ISetting> RemoveSetting(ISetting setting)
        {
           if(setting == null) throw new ArgumentNullException(nameof(setting));

            try
            {
                this._dbContext.Settings.Remove(setting as Setting);
                await this._dbContext.SaveChangesAsync();
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }

            return setting;
        }
    }
}