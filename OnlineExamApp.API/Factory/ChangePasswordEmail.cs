using System.Threading.Tasks;
using OnlineExamApp.API.Dto;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Factory
{
    public class ChangePasswordEmail : IEmailTemplate
    {
        
        public string _email { get; set; }
        public string _token { get; set; }
        public IAppSettingsService _appSettingsService { get; }

        public ChangePasswordEmail(IAppSettingsService appSettingsService)
        {
            this._appSettingsService = appSettingsService;
        }

        
        public async Task<EmailTemplateResponse> Template()
        {
            var template = new EmailTemplateResponse();

            var confirmationURL = $"{await _appSettingsService.BaseUrl}/api/account/confirmchange?email={_email}&token={_token}";

            template.Subject = "Change Password";

            template.PlainTextContent = "Click on the link below to change your password";

            template.HtmlContent = $"<p>PClick on the link below to change your password.<p><a href=\"{confirmationURL}\">Click to change password.</a></p>";

            return template;
        }
    }
}