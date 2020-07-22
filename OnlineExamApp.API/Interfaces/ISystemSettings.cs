using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Interfaces
{
    public interface ISystemSettings
    {
        Task<IEnumerable<ISettings>> GetSetting();
    }
}