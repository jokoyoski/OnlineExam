namespace OnlineExamApp.API.Dto
{
    public class EmailTemplateResponse
    {
        public string Subject { get; set; }
        public string PlainTextContent { get; set; }
        public string HtmlContent { get; set; }
    }
}