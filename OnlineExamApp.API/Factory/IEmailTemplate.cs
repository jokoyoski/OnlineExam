using System;
using OnlineExamApp.API.Dto;

namespace OnlineExamApp.API.Factory
{
    public interface IEmailTemplate
    {
        EmailTemplateResponse  Template ();
    }
}