using System;
using System.Threading.Tasks;
using OnlineExamApp.API.Dto;

namespace OnlineExamApp.API.Factory
{
    public interface IEmailTemplate
    {
        Task<EmailTemplateResponse>  Template ();
    }
}