using OnlineExamApp.API.Dto;

namespace OnlineExamApp.API.Factory
{
    public class AccountVerificationEmail : IEmailTemplate
    {
        private string _email;
        private string _token;

        public AccountVerificationEmail(string email, string token)
        {
            _email = email;
            _token = token;   
        }

        //TODO:
        public EmailTemplateResponse Template()
        {
            var template = new EmailTemplateResponse();

            var confirmationURL = $"http://localhost:5000/api/account/{_email}/{_token}";

            template.Subject = "Activate Account";

            template.PlainTextContent = "Welcome to Online Exam Platform./n Practice for your Jamb, NECO and WAEC with past questions and practice center./n You have a 3 free test trial sessions";

            template.HtmlContent = $"<h3>Welcome to Online Exam Platform</h3><p>Practice for your Jamb, NECO and WAEC with past questions and practice center.</p><p>You have a 3 free test trial sessions.</p><p><a href={confirmationURL}>Click to Activate your account.</a></p>";

            return template;
        }
    }
}