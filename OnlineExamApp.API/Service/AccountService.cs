using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Service
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager,
            IConfiguration _config, IMapper mapper)
        {
            this._mapper = mapper;
            this._config = _config;
            this._signInManager = signInManager;
            this._userManager = userManager;

        }
        public async Task<string> SignIn(Dto.UserForLoginDto userForLogInDto)
        {

            var user = await _userManager.FindByNameAsync(userForLogInDto.Username);

            var result = await _signInManager
                .CheckPasswordSignInAsync(user, userForLogInDto.Password, false);


            if (result.Succeeded)
            {
                 
                var appUser =  _userManager.Users
                    .FirstOrDefault(u => u.NormalizedUserName == userForLogInDto.Username.ToUpper());

                return GenerateJwtToken(appUser).Result;
               
            }

            return string.Empty;
        }
        public async Task<string> SignUp(Dto.UserForRegisterDto userForRegisterDto)
        {
           string errorInfo= string.Empty;
            string token = string.Empty;

            var userToCreate = _mapper.Map<User>(userForRegisterDto);

            var result = await _userManager.CreateAsync(userToCreate, userForRegisterDto.Password);

            if (result.Succeeded)
            {
               var userroles= this._userManager.AddToRolesAsync(userToCreate, new[] { "USER" });
                
                return "";
            }

             foreach(var error in result.Errors)  
             {
                 errorInfo=error.Description;
             }
            return errorInfo;


        }
        private async Task<string> GenerateJwtToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim (ClaimTypes.NameIdentifier, user.Id.ToString ()),
                new Claim (ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.GivenName,user.FirstName)
            };

            var roles = await _userManager.GetRolesAsync(user);

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

    }
}