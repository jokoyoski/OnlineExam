using System.Threading.Tasks;
using OnlineExamApp.API.Dto;

namespace OnlineExamApp.API.Factory
{
    public class ScoreDetailsEmail : IEmailTemplate
    {
        public int _score { get; set; }
        
        public async Task<EmailTemplateResponse> Template()
        {
            var template = new EmailTemplateResponse();

            template.Subject = "TISA Score";

            template.PlainTextContent = $"Your {_score}";

            template.HtmlContent = $"<p>Your {_score}<p>";

            return template;
        }
    }
}