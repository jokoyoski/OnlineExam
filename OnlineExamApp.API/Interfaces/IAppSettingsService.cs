using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IAppSettingsService
    {
        Task<string> BaseUrl { get; }

        Task<string> SendGridAPIKey { get; } 
        
        Task<string> AdminEmail { get; }

        Task<string> AdminName { get; }
    }
}