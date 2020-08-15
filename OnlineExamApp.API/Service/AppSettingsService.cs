using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Service
{
    public class AppSettingsService : IAppSettingsService
    {
        private readonly ISystemSettingRepository _systemSettings;
        private readonly ICacheService _cacheService;

        public AppSettingsService(ISystemSettingRepository systemSettings, ICacheService cacheService)
        {
            _systemSettings = systemSettings;
            _cacheService = cacheService;
        }

        public Task<string> BaseUrl => SystemSettings("BaseUrl"); 

        public Task<string> QuestionRipperUrl => SystemSettings("QuestionRipperUrl");
        
        public Task<string> TerminalId => SystemSettings("TerminalId");

        public Task<string> SendGridAPIKey  => SystemSettings("SendGridAPIKey");

        public Task<string> AdminEmail  => SystemSettings("AdminEmail");

        public Task<string> AdminName  => SystemSettings("AdminName");

        public Task<string> DeactivateDay => SystemSettings("DeactivateDay");

        public async Task<string>  SystemSettings(string key)
        {
             var value = _cacheService.Get<string>($"::{key}::");

            if(value == null)
            {
                var  settings = await GetSettings();

                var setting = settings.Where(p=>p.Key.Equals(key)).SingleOrDefault();

                value = setting.Value;
                
                 _cacheService.Add<string>($"::{key}::", value);
            }

            return value;    
        } 

        #region  System Settings CRUD

        public async Task<IList<Setting>> GetSettings()
        {
            var settings = await _systemSettings.GetSettings();

            return settings;
        }

        public async Task<ISetting> GetSetting(int settingId)
        {
            if(settingId <= 0) throw new ArgumentNullException(nameof(settingId));

            return await _systemSettings.GetSetting(settingId);;
        }

        public async Task<string> AddSetting(ISetting setting)
        {
            string result = string.Empty;

            if(setting == null) return $"Setting is null";

            var stn = await _systemSettings.AddSetting(setting);

            if(stn == null) return $"Request was not successful";

            return result;
        }

        public async Task<string> EditSetting(ISetting setting)
        {   
            string result = string.Empty;

            if(setting == null) return $"Setting is null";

            var stn = await _systemSettings.UpdateSetting(setting);

            if(stn == null) return $"Request was not successful";

            return result;
        } 
        
        public async Task<string> RemoveSetting(ISetting setting)
        {
            string result = string.Empty;

            if(setting == null) return $"Setting is null";

            var stn = await _systemSettings.RemoveSetting(setting);

            if(stn == null) return $"Request was not successful";

            return result;
        }

        #endregion
    }
}