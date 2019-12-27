using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineExamApp.API.Interfaces;
using System.Security.Claims;
using Newtonsoft.Json;
using OnlineExamApp.API.Dto;

namespace OnlineExamApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService questionService;
        public QuestionController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }
        [HttpGet()]
        public async Task<IActionResult> GetCategories()
        {
            var model = await this.questionService.GetCategories();

            return Ok(model);
        }
        [HttpGet("{userId}/{categoryId}")]
        public async Task<IActionResult> GetQuestions(int userId, int categoryId)
        {   
            if(userId <= 0) throw new ArgumentNullException(nameof(userId));

            if (userId != int.Parse (User.FindFirst(ClaimTypes.NameIdentifier).Value))
               return Unauthorized ();

            if(categoryId <= 0) throw new ArgumentNullException(nameof(categoryId));

            var model = await this.questionService.GetQuestionListForDislay(userId, categoryId);

            return Ok(model);
        }
        [HttpPost("{userId}/submitTest")]
        public async Task<IActionResult> SubmitTest(int userId, List<AnweredQuestionDto> anweredQuestion )
        {

            if(userId <= 0) throw new ArgumentNullException(nameof(userId));

            if (userId != int.Parse (User.FindFirst(ClaimTypes.NameIdentifier).Value))
               return Unauthorized ();

          //  var anweredQuestionDto = System.IO.File.ReadAllText("Dto/AnsweredQuestion.json");

          //  var anweredQuestion = JsonConvert.DeserializeObject<List<AnweredQuestionDto>>(anweredQuestionDto);

            var model = await this.questionService.ProcessAnweredQuestions(userId, anweredQuestion);

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