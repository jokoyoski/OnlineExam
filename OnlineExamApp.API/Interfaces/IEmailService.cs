

using System;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Interfaces
{
    public interface IEmailService
    {
        Task Execute(Enum emailType);
    }
}