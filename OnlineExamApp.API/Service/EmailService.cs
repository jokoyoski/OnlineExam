
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
        private const string FromEmail = "bomana.ogoni@gmail.com";
        private const string FromName = "Bomanaziba Ogoni";
        private readonly string _environment;
        private readonly string _toEmail; 
        private readonly string _toName;
        
        public EmailService(IEmailTemplate template, string toName, string toEmail, string environment)
        {
            _environment = environment;
            _template = template;
            _toName = toName;
            _toEmail = toEmail;
        }

        public async Task Execute(Enum emailType)
        {
            var apiKey = Environment.GetEnvironmentVariable(_environment);
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(FromEmail, FromName);
            var subject = string.Empty;
            var to = new EmailAddress(_toEmail, _toName);

            switch(emailType)
            {
                case EmailType.AccountVerification:
                    //TODO: Account Verification Template
                    _template = new AccountVerificationEmail();
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

            var msg = MailHelper.CreateSingleEmail(from, to, _template.Template().Subject, _template.Template().PlainTextContent, _template.Template().HtmlContent);
            var response = await client.SendEmailAsync(msg);
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