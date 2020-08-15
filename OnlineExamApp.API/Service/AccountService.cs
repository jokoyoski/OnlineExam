using System;
using System.Collections.Generic;
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
using Mono.Web;

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

                _ = await _emailService.Execute(EmailType.AccountVerification);

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

            if(user == null)
            {
                result = "User not found";
            }

            var output = await this._userManager.ConfirmEmailAsync(user, token);

            if(!output.Succeeded)
            {
                result = output.Errors.FirstOrDefault().ToString();
            }

            return result;
        }

        public async Task<string> ProcessChangePassword(string email)
        {

            string result = string.Empty;

            if (email == null) throw new ArgumentNullException(nameof(email));

            var user = await this._userManager.FindByEmailAsync(email);

            if(user == null)
            {
                result = "User not found";
                return result;
            }

            _emailService._toEmail = user.Email;
            _emailService._toName = user.LastName + " " + user.FirstName;

            var token = await this._userManager.GeneratePasswordResetTokenAsync(user);

            _emailService._token = token;

            await _emailService.Execute(EmailType.ChangePassword);

            return result;

        }

        public async Task<string> ProcessConfirmChangePassword(IChangePasswordDto changePassword)
        {

            string result = string.Empty;
            
            
            if(changePassword == null) throw new ArgumentNullException(nameof(changePassword));

            if(string.IsNullOrEmpty(changePassword.Email)) throw new ArgumentNullException(nameof(changePassword.Email));

            if(string.IsNullOrEmpty(changePassword.Token)) throw new ArgumentNullException(nameof(changePassword.Token));

            if(string.IsNullOrEmpty(changePassword.NewPassword)) throw new ArgumentNullException(nameof(changePassword.NewPassword));

            var user = await this._userManager.FindByEmailAsync(changePassword.Email);

            if(user == null)
            {
                result = "User not found";
            }

            try
            {

                var identity = await this._userManager.ResetPasswordAsync(user, changePassword.Token, changePassword.NewPassword);

                if (!identity.Succeeded)
                {
                    result = "Unable to reset password";
                }
            }
            catch(Exception e)
            {
                result = $"{e.Message}";
            }

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
            
            userInfo.Trials += numberOfTrials;

            var output = await this._userManager.UpdateAsync(userInfo);

            if (!output.Succeeded)
            {
                result = output.Errors.ToString();
            }

            _emailService._toEmail = userInfo.Email;
            _emailService._toName = userInfo.LastName + " " + userInfo.FirstName;
            _emailService._coin = numberOfTrials;

           await _emailService.Execute(EmailType.Purchase);

            return result;
        }
    }
}