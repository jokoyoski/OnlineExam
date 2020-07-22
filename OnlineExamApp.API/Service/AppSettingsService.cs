using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Service
{
    public class AppSettingsService : IAppSettingsService
    {
        private readonly ISystemSettings _systemSettings;

        public AppSettingsService(ISystemSettings systemSettings)
        {
            _systemSettings = systemSettings;
        }

        public Task<string> BaseUrl => SystemSettings("BaseUrl"); 

        public Task<string> SendGridAPIKey  => SystemSettings("SendGridAPIKey");

        public Task<string> AdminEmail  => SystemSettings("AdminEmail");

        public Task<string> AdminName  => SystemSettings("AdminName");
        

        public async Task<string>  SystemSettings(string key)
        {
            var settings = await _systemSettings.GetSetting();

            var setting = settings.Where(p=>p.Key.Equals(key)).SingleOrDefault();

            return setting.Value;    
        } 
    }
}