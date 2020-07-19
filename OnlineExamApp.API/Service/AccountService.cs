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
using Microsoft.AspNetCore.Mvc;
using OnlineExamApp.API.Dto;
using static OnlineExamApp.API.Service.EmailService;

namespace OnlineExamApp.API.Service
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        
        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager,
            IConfiguration config, IMapper mapper, IEmailService emailService)
        {
            _mapper = mapper;
            _config = config;
            _signInManager = signInManager;
            _userManager = userManager;
            _emailService = emailService;
        }

        public async Task<string> SignIn(UserForLoginDto userForLogInDto)
        {
            if (userForLogInDto == null) throw new ArgumentNullException(nameof(userForLogInDto));

            var user = await _userManager.FindByNameAsync(userForLogInDto.Username);

            if (user == null) return "User not found";

            var result = await _signInManager
                .CheckPasswordSignInAsync(user, userForLogInDto.Password, false);

            if (result.Succeeded)
            {
                var appUser = _userManager.Users
                    .FirstOrDefault(u => u.NormalizedUserName == userForLogInDto.Username.ToUpper());
                return GenerateJwtToken(appUser).Result;
            }

            return string.Empty;
        }

        public async Task<string> SignUp(UserForRegisterDto userForRegisterDto)
        {
            string errorInfo = string.Empty;

            var userToCreate = _mapper.Map<User>(userForRegisterDto);

            userToCreate.Trials = 3;

            var result = await _userManager.CreateAsync(userToCreate, userForRegisterDto.Password);

            if (result.Succeeded)
            {
                var userroles = this._userManager.AddToRolesAsync(userToCreate, new[] { "USER" });

                var token = await this._userManager.GenerateEmailConfirmationTokenAsync(userToCreate);

                _emailService._toEmail = userToCreate.Email;
                _emailService._toName = userToCreate.LastName + " " + userToCreate.FirstName;

                _emailService._token = token;
                _emailService._email = userForRegisterDto.Email;

                _emailService.Execute(EmailType.AccountVerification);

                return "";
            }

            foreach (var error in result.Errors)
            {
                errorInfo = error.Description;
            }
            return errorInfo;

        }

        public async Task<string> ProcessConfirmEmail(string email, string token)
        {

            string result = string.Empty;

            if(string.IsNullOrEmpty(email)) throw new ArgumentNullException(nameof(email));
            
            if(string.IsNullOrEmpty(token)) throw new ArgumentNullException(nameof(token));


            var user = await this._userManager.FindByEmailAsync(email);

            var output = await this._userManager.ConfirmEmailAsync(user, token);

            if(!output.Succeeded)
            {
                result = output.Errors.ToString();
            }

            return result;
        }

        public async Task<string> ProcessChangePassword(IChangePasswordDto changePasswordDto)
        {

            string result = string.Empty;

            var us = _userManager.FindByIdAsync(ClaimTypes.NameIdentifier);

            if (changePasswordDto == null) throw new ArgumentNullException(nameof(changePasswordDto));

            var user = await this._userManager.FindByIdAsync(changePasswordDto.UserId.ToString());

            var identity = await this._userManager.ChangePasswordAsync(user, changePasswordDto.NewPassword, changePasswordDto.NewPassword);

            if (!identity.Succeeded)
            {
                result = identity.Errors.ToString();

                return result;
            }


            _emailService._toEmail = user.Email;
            _emailService._toName = user.LastName + " " + user.FirstName;

            _emailService.Execute(EmailType.ChangePassword);

            return result;

        }
        private async Task<string> GenerateJwtToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim (ClaimTypes.NameIdentifier, user.Id.ToString ()),
                new Claim (ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.GivenName,user.FirstName),
                new Claim(ClaimTypes.PrimarySid,user.Trials.ToString())
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
        
        public async Task<string> GetTrials(int userId, int numberOfTrials)
        {
            string result = string.Empty;
            bool isExist = true;

            var userInfo = await this._userManager.FindByIdAsync(userId.ToString());

            isExist = (userInfo == null) ? false : true;

            if (!isExist)
            {
                return "User Does not Exist";
            }

            //TODO: Account for the number of trials bought by the users
            userInfo.Trials += numberOfTrials;

            var output = await this._userManager.UpdateAsync(userInfo);

            if (!output.Succeeded)
            {
                result = output.Errors.ToString();
            }

            _emailService._toEmail = userInfo.Email;
            _emailService._toName = userInfo.LastName + " " + userInfo.FirstName;

            _emailService.Execute(EmailType.Purchase);

            return result;
        }
    }
}