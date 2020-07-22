
using System;
using System.Threading.Tasks;
using OnlineExamApp.API.Factory;
using OnlineExamApp.API.Interfaces;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace OnlineExamApp.API.Service
{
    public class EmailService : IEmailService
    {
        
        IEmailTemplate _template;
        private readonly IAppSettingsService _appSettings;
        private string FromEmail;
        private string FromName;
        public string _environment { get; set; }
        public string _toEmail { get; set; }
        public string _toName { get; set; }
        public string _token { get; set; }
        public string _email { get; set; }       

        public EmailService(IEmailTemplate template, IAppSettingsService appSettings)
        {
            
            _template = template;
            _appSettings = appSettings;
        }

        public async Task<Response> Execute(Enum emailType)
        {
            FromEmail = await _appSettings.AdminEmail;
            FromName = await _appSettings.AdminName;
            
            var apiKey = await _appSettings.SendGridAPIKey;  
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(FromEmail, FromName);
            var to = new EmailAddress(_toEmail, _toName);


            switch(emailType)
            {
                case EmailType.AccountVerification:
                    var accountVerification = new AccountVerificationEmail(_appSettings);
                    accountVerification._email = _email;
                    accountVerification._token = _token;
                    _template = accountVerification;
                    
                    break;
                case EmailType.ScoreDetail:
                    //TODO: ScoreDetails Template
                    _template = new ScoreDetailsEmail();
                    break;
                case EmailType.Purchase:
                    //TODO: Purchase Template
                    _template = new PurchaseDetailsEmail();
                    break;
                case EmailType.ChangePassword:
                    //TODO: Purchase Template
                    _template = new ChangePasswordEmail();
                    break;
                default:
                    break;
            }
            var item = await _template.Template();

            var msg = MailHelper.CreateSingleEmail(from, to, item.Subject, item.PlainTextContent, item.HtmlContent);
            var response = await client.SendEmailAsync(msg);

            return response;
        }

        public enum EmailType
        {
            AccountVerification,
            ChangePassword,
            ScoreDetail,
            Purchase
        }
    } 
}