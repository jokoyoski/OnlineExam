using System;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineExamApp.API.Dto;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Controllers
{
    //[Authorize(Policy="AdminPolicy")]
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        private readonly ICacheService _cacheService;
        private readonly IAppSettingsService _appSettingsService;
        private readonly ICategoryService _categoryService;
        private readonly IPaymentService _paymentService;

        public AdminController(IQuestionService questionService, ICacheService cacheService, 
                               IAppSettingsService appSettingsService, ICategoryService categoryService,
                               IPaymentService paymentService)
        {
            this._questionService = questionService;
            this._cacheService = cacheService;
            this._appSettingsService = appSettingsService;
            this._categoryService = categoryService;
            this._paymentService = paymentService;
        }

        [HttpPost("import")]
        public async Task<IActionResult> Import([FromForm]UploadQuestionDto formFile)
        {
            if (formFile == null || formFile.File.Length <= 0)
            {
               return  BadRequest("You uploaded an empty file");
            }

            if (!Path.GetExtension(formFile.File.FileName).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
            {
                return BadRequest("invalid file format");
            }

            var result  = await this._questionService.SaveQuestion(formFile);

            return Ok(result);
        }

        [HttpPost("resync")]
        public async Task<IActionResult> Resync()
        {
            _cacheService.RemoveAllFromCache();

            return Ok("Resynce Successful");
        }
        
        #region  System Setting CRUD

        [HttpGet("settings")]
        public async Task<IActionResult> GetSettings()
        {
            var roles = await _appSettingsService.GetSettings();

            return Ok(roles);
        }

        [HttpGet("setting/{id}")]
        public async Task<IActionResult> GetSetting(int id)
        {
            if(id <= 0) return BadRequest($"{id} is less than or equal 0");

            var role = await _appSettingsService.GetSetting(id);

            return Ok(role);
        }
        
        [HttpPost("setting/add")]
        public async Task<IActionResult> AddSettings([FromBody]Setting setting)
        {
            if(setting == null) return BadRequest("Setting is null");

            var stn = await _appSettingsService.AddSetting(setting);

            if(!string.IsNullOrEmpty(stn)) return NotFound(stn);
            
            return Created("settings/add", setting);
        }
        
        [HttpPost("setting/edit")]
        public async Task<IActionResult> EditSettings([FromBody]Setting setting)
        {
            if(setting == null) return BadRequest("Setting is null");

            var stn = await _appSettingsService.EditSetting(setting);

            if(!string.IsNullOrEmpty(stn)) return NotFound(stn);
            
            return Ok($"Successfully edited {setting.Key}");
        }

        [HttpPost("setting/delete")]
        public async Task<IActionResult> DeleteSettings([FromBody]Setting setting)
        {
           if(setting == null) return BadRequest("Setting is null");

            var stn = await _appSettingsService.RemoveSetting(setting);

            if(!string.IsNullOrEmpty(stn)) return NotFound(stn);
            
            return Ok($"Successfully deleted {setting.Key}");
        }

        #endregion

        #region  Question CRUD

        [HttpGet("question/{categoryId}")]
        public async Task<IActionResult> GetQuestion(int categoryId)
        {
            if(categoryId <= 0) return BadRequest($"{categoryId} is less than or equal 0");

            var questions = await _questionService.GetQuestion(categoryId);

            return Ok(questions);
        }

        [HttpPost("question/add")]
        public async Task<IActionResult> AddQuestion(Question question)
        {

            if(question == null) return BadRequest($"{question} is null");

            var qtn = await _questionService.AddQuestion(question);

            if(!string.IsNullOrEmpty(qtn)) return NotFound(qtn);

            return Created("question/add", qtn);
        }
        
        [HttpPost("question/edit")]
        public async Task<IActionResult> EditQuestion(Question question)
        {
            
            if(question == null) return BadRequest($"{question} is null");

            var qtn = await _questionService.EditQuestion(question);

            if(!string.IsNullOrEmpty(qtn)) return NotFound(qtn);

            return Ok("Successfully edited question");
        }

        [HttpPost("question/delete")]
        public async Task<IActionResult> DeleteQuestion(Question question)
        {
            if(question == null) return BadRequest($"{question} is null");

            var qtn = await _questionService.DeleteQuestion(question);

            if(!string.IsNullOrEmpty(qtn)) return NotFound(qtn);

            return Ok("Successfully deleted question");
        }

        #endregion
    
        #region  Question Option CRUD
        
        [HttpPost("option/add")]
        public async Task<IActionResult> AddOption(Option option)
        {
            if(option == null) return BadRequest($"{option} is null");

            var opn = await _questionService.AddOption(option);

            if(!string.IsNullOrEmpty(opn)) return NotFound(opn);

            return Created("option/add", opn);
        }
        
        [HttpPost("option/edit")]
        public async Task<IActionResult> EditOption(Option option)
        {
            if(option == null) return BadRequest($"{option} is null");

            var opn = await _questionService.EditOption(option);

            if(!string.IsNullOrEmpty(opn)) return NotFound(opn);

            return Ok("Successfully Edited");
        }

        [HttpPost("option/delete")]
        public async Task<IActionResult> DeleteOption(Option option)
        {
            if(option == null) return BadRequest($"{option} is null");

            var opn = await _questionService.DeleteOption(option);

            if(!string.IsNullOrEmpty(opn)) return NotFound(opn);

            return Ok("Successfully Deleted");
        }

        #endregion
    
        #region Transactions 

        #endregion

    }
}