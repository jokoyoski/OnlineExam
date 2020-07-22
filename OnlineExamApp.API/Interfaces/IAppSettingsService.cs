using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IAppSettingsService
    {
        Task<string> BaseUrl { get; }

        Task<string> SendGridAPIKey { get; } 
        
    }
}