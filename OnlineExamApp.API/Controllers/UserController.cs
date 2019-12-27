using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            this._userService = userService;
        }
        [HttpGet("{userId}/{categoryId}")]
        public async Task<IActionResult> GetUserScore(int userId, int categoryId)
        {
            if (userId != int.Parse (User.FindFirst(ClaimTypes.NameIdentifier).Value))
               return Unauthorized ();

            if(categoryId <= 0) throw new ArgumentNullException(nameof(categoryId));

            var model = await this._userService.GetUserPerformanceByCatetgory(userId, categoryId);

            if(model != null) 
            {
                return Ok(model);
            }

            return NoContent();
        }
    }
}