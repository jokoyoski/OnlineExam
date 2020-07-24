using System.Threading.Tasks;
using OnlineExamApp.API.Dto;

namespace OnlineExamApp.API.Factory
{
    public class PurchaseDetailsEmail : IEmailTemplate
    {

        public int _coin { get; set; }

        //TODO;
        public async Task<EmailTemplateResponse> Template()
        {
            var template = new EmailTemplateResponse();

            template.Subject = "TISA Coin";

            template.PlainTextContent = $"You just purchased {_coin} TISA coin";

            template.HtmlContent = $"<p>You just purchased {_coin} TISA coin<p>";

            return template;
        }
    }
}