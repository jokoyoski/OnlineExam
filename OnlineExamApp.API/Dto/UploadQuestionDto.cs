
using Microsoft.AspNetCore.Http;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class UploadQuestionDto : IUploadQuestionDto
    {
        public IFormFile File { get; set; }
        public int CategoryId { get; set; }
    }
}