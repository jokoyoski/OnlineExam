using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface ISystemSettingRepository
    {
        Task<IList<Setting>> GetSettings();
        Task<ISetting> GetSetting(int settingId);
        Task<ISetting> AddSetting(ISetting settings);
        Task<ISetting> UpdateSetting(ISetting settings);
        Task<ISetting> RemoveSetting(ISetting settings);
    }
}