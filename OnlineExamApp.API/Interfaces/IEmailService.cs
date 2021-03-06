

using System;
using System.Threading.Tasks;
using SendGrid;

namespace OnlineExamApp.API.Interfaces
{
    public interface IEmailService
    {
        string _token { get; set; }
        string _email { get; set; }   
        string _environment { get; set; }
        string _toEmail { get; set; }
        string _toName { get; set; }
        int _coin { get; set; }
        Task<Response> Execute(Enum emailType);
    }
}