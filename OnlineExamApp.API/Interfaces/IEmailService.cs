

using System;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IEmailService
    {
        string _environment { get; set; }
        string _toEmail { get; set; }
        string _toName { get; set; }
        Task Execute(Enum emailType);
    }
}