

using Microsoft.AspNetCore.Http;

namespace OnlineExamApp.API.Interfaces
{
    public interface IUploadQuestionDto
    {
        IFormFile File { get; set; }   
        int CategoryId { get; set; }
    }
}