
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using OnlineExamApp.API.Dto;
using System;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            this._accountService = accountService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.Username=userForRegisterDto.Email;

            if(userForRegisterDto == null) throw new ArgumentNullException(nameof(userForRegisterDto));

            var model = await this._accountService.SignUp(userForRegisterDto);

            if (string.IsNullOrEmpty(model))
            {
                
                return Ok(new
                {
                    success = "User Has been Registered Successfully",
                    
                });
            }
            return BadRequest(model);
        }

        
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]UserForLoginDto userForLogInDto)
        {
            if(userForLogInDto == null) throw new ArgumentNullException(nameof(userForLogInDto));

            var model = await this._accountService.SignIn(userForLogInDto);

            if(model.Equals("User not found")) return BadRequest("User not found");

            if(!string.IsNullOrEmpty(model)){
                return Ok(new
                {
                    token = model
                });
            } 

            return Unauthorized("You are not authorized");
        }

    }

}








