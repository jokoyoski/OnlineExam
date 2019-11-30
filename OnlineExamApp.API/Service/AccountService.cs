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
                //TODO: Add more content in the token
                var appUser = await _userManager.Users
                    .FirstOrDefaultAsync(u => u.NormalizedUserName == userForLogInDto.Username.ToUpper());

                return GenerateJwtToken(appUser).Result;
               
            }

            return string.Empty;
        }
        public async Task<string> SignUp(Dto.UserForRegisterDto userForRegisterDto)
        {

            string token = string.Empty;

            var userToCreate = _mapper.Map<User>(userForRegisterDto);

            var result = await _userManager.CreateAsync(userToCreate, userForRegisterDto.Password);

            if (result.Succeeded)
            {
                await this._userManager.AddToRolesAsync(userToCreate, new[] { "USER" });
                //TODO: Add more information to token
                var appUser = await _userManager.Users
                    .FirstOrDefaultAsync(u => u.NormalizedUserName == userForRegisterDto.Username.ToUpper());

                token = await GenerateJwtToken(appUser);

                return token;
            }

            if (!string.IsNullOrEmpty(result.Errors.ToString()))
            {
                return result.Errors.ToString();
            }

            return token;


        }
        private async Task<string> GenerateJwtToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim (ClaimTypes.NameIdentifier, user.Id.ToString ()),
                new Claim (ClaimTypes.Name, user.UserName)
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