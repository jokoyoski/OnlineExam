using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface IAppSettingsService
    {
        Task<string> BaseUrl { get; }
        Task<string> SendGridAPIKey { get; } 
        Task<string> AdminEmail { get; }
        Task<string> AdminName { get; }
        Task<string> DeactivateDay { get; }
        Task<string> QuestionRipperUrl { get; }
        Task<string> TerminalId { get; }
        Task<IList<Setting>> GetSettings();
        Task<ISetting> GetSetting(int settingId);
        Task<string> AddSetting(ISetting setting);
        Task<string> EditSetting(ISetting setting);
        Task<string> RemoveSetting(ISetting setting);
    }
}