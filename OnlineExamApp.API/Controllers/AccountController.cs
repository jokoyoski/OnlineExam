
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using OnlineExamApp.API.Dto;
using System;
using OnlineExamApp.API.Interfaces;
using System.Security.Claims;

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
            userForRegisterDto.Username = userForRegisterDto.Email;

            if (userForRegisterDto == null) throw new ArgumentNullException(nameof(userForRegisterDto));

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
            if (userForLogInDto == null) throw new ArgumentNullException(nameof(userForLogInDto));

            var model = await this._accountService.SignIn(userForLogInDto);

            if (model.Equals("User not found")) return BadRequest("User not found");

            if (!string.IsNullOrEmpty(model))
            {
                return Ok(new
                {
                    token = model
                });
            }

            return Unauthorized("You are not authorized");
        }
        [HttpPost("changepassword")]
        [HttpGet("{userId}/{code}")]
        public async Task<IActionResult> ConfirmEmail(int userId, string code)
        {
            if (userId <= 0) throw new ArgumentNullException(nameof(userId));

            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            var model = await this._accountService.ProcessConfirmEmail(userId, code);
            
            if(!string.IsNullOrEmpty(model)){
                return BadRequest(model);
            }

            return Ok("Successfully confirmed email.");
        }
        public async Task<IActionResult> ChangePassword([FromBody]ChangePasswordDto changePasswordDto)
        {
            if (changePasswordDto == null) throw new ArgumentNullException(nameof(changePasswordDto));

            var model = await this._accountService.ProcessChangePassword(changePasswordDto);

            if (!string.IsNullOrEmpty(model))
            {
                return Ok("Successfully changed password.");
            }

            return BadRequest(model);
        }
        [HttpPost("{userId}/{numberOfTrials}")]
        public async Task<IActionResult> BuyTrial(int userId, int numberOfTrials)
        {
            if (userId <= 0) throw new ArgumentNullException(nameof(userId));

            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            if (numberOfTrials <= 0) throw new ArgumentNullException(nameof(numberOfTrials));

            var model = await this._accountService.GetTrials(userId, numberOfTrials);

            if (!string.IsNullOrEmpty(model))
            {
                return NotFound(model);
            }

            return Ok(model);
        }
    }
}








