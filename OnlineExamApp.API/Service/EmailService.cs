
using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace OnlineExamApp.API.Service
{
    public static class EmailService
    {
        static async Task Execute(string fromEmail, string toEmail, Enum emailType)
        {
            var apiKey = Environment.GetEnvironmentVariable("NAME_OF_THE_ENVIRONMENT_VARIABLE_FOR_YOUR_SENDGRID_KEY");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(fromEmail);
            var subject = string.Empty;
            var to = new EmailAddress(toEmail);

            //ToDo: Email Template from Factory
            var plainTextContent = string.Empty;
            var htmlContent = string.Empty;

            switch(emailType)
            {
                case EmailType.AccountVerification:
                    //TODO: Account Verification Template
                    break;
                case EmailType.ScoreDetail:
                    //TODO: ScoreDetails Template
                    break;
                case EmailType.Purchase:
                    //TODO: Purchase Template
                    break;
                default:
                    break;

                
            }
            
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }

        public enum EmailType
        {
            AccountVerification,
            ScoreDetail,
            Purchase
        }
    } 
}