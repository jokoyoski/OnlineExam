using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private readonly IQuestionService questionService;
        public QuestionController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuestions([FromQuery] int categoryId)
        {
            if(categoryId <= 0) throw new ArgumentNullException(nameof(categoryId));

            var model = await this.questionService.GetQuestionListForDislay(categoryId);

            return Ok(model);
        }

        /* [HttpPost("import")]
        public async Task<IActionResult> Import([FromForm]IFormFile formFile)
        {
            if (formFile == null || formFile.Length <= 0)
            {
                return BadRequest("You uploaded an empty file");
            }

            if (!Path.GetExtension(formFile.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                return BadRequest("invalid file format");
            }

            var file = this.questionRepo.saveQuestion(formFile);

            return Ok(file);

        } */
    }
}