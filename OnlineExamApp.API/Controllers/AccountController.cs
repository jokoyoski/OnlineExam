
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using OnlineExamApp.API.Model;
using System.Threading.Tasks;
using OnlineExamApp.API.Dto;
using System.Security.Claims;
using System;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.IO;
using OfficeOpenXml;
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
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            if(userForRegisterDto == null) throw new ArgumentNullException(nameof(userForRegisterDto));

            var model = await this._accountService.SignUp(userForRegisterDto);

            if (!string.IsNullOrEmpty(model))
            {
                return Ok(new
                {
                    success = "User Has been Registered Successfully, You can then proceed to login",
                    token = model

                });
            }
            return BadRequest();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLogInDto)
        {
            if(userForLogInDto == null) throw new ArgumentNullException(nameof(userForLogInDto));

            var model = await this._accountService.SignIn(userForLogInDto);

            if(string.IsNullOrEmpty(model)){
                return Ok(new
                {
                    token = model
                });
            }
            return BadRequest("You are not authorized");
        }

    }

}








