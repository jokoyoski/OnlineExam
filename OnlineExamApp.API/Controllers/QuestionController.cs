using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineExamApp.API.Interfaces;
using System.Security.Claims;
using Newtonsoft.Json;
using OnlineExamApp.API.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace OnlineExamApp.API.Controllers
{
    [Authorize]
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

            var model = await this.questionService.ProcessAnweredQuestions(userId, anweredQuestion);

            return Ok(model);
        }
 }
}