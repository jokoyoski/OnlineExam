using System.Threading.Tasks;
using OnlineExamApp.API.Dto;
using OnlineExamApp.API.Interfaces;
using Mono.Web;


namespace OnlineExamApp.API.Factory
{
    public class AccountVerificationEmail : IEmailTemplate
    {
        public string _email { get; set; }
        public string _token { get; set; }
        public IAppSettingsService _appSettingsService { get; }

        public AccountVerificationEmail(IAppSettingsService appSettingsService)
        {
            _appSettingsService = appSettingsService;
        }

        public async Task<EmailTemplateResponse> Template()
        {
            var template = new EmailTemplateResponse();

            var confirmationURL = $"{await _appSettingsService.BaseUrl}/api/account/confirmemail?email={_email}&token={_token}";

            template.Subject = "Activate Account";

            template.PlainTextContent = "Welcome to Online Exam Platform./n Practice for your Jamb, NECO and WAEC with past questions and practice center./n You have a 3 free test trial sessions";

            template.HtmlContent = $"<h3>Welcome to Online Exam Platform</h3><p>Practice for your Jamb, NECO and WAEC with past questions and practice center.</p><p>You have a 3 free test trial sessions.</p><p><a href=\"{confirmationURL}\">Click to Activate your account.</a></p>";

            return template;
        }
    }
}