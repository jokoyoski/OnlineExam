using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineExamApp.API.Dto;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

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
           // if (userId != int.Parse (User.FindFirst(ClaimTypes.NameIdentifier).Value))
            //   return Unauthorized ();

            if(categoryId <= 0) throw new ArgumentNullException(nameof(categoryId));

            var model = await this._userService.GetUserPerformanceByCatetgory(userId, categoryId);

            if(model != null) 
            {
                return Ok(model);
            }

            return NoContent();
        }
    

        #region  User CRUD

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var settings = await _userService.Users();
            
            return Ok(settings);
        }

        
        [HttpGet("{userId}")]
        public async Task<IActionResult> Get(int userId)
        {

            if(userId <= 0) return BadRequest($"{userId} is less than one");

            var model = await this._userService.GetUserById(userId);

            if(model == null) 
            {
                return NotFound($"No User found with {userId}");
            }

            return Ok(model);
        }
        
        [HttpPost("add")]
        public async Task<IActionResult> AddUser([FromBody]User user)
        {
            if(user == null) return BadRequest($"User is null");

            var userResponse = await _userService.AddUser(user);

            if(!string.IsNullOrEmpty(userResponse)) return NotFound(userResponse); 

            return Created("user/add" ,user);
        }
        
        [HttpPost("edit")]
        public async Task<IActionResult> EditSettings([FromBody]User user)
        {
            if(user == null) return BadRequest($"User is null");

            var userResponse = await _userService.EditUser(user);

            if(!string.IsNullOrEmpty(userResponse)) return NotFound(userResponse); 

            return Ok($"Successfully edited {user.LastName}");
        }

        [HttpPost("deactivate")]
        public async Task<IActionResult> Deactivate([FromBody]User user)
        {
            if(user == null) return BadRequest($"User is null");

            var userResponse = await _userService.Deactivate(user);

            if(!string.IsNullOrEmpty(userResponse)) return NotFound(userResponse); 

            return Ok($"Successfully deactivated {user.LastName}");
        }

        [HttpPost("activate")]
        public async Task<IActionResult> Activate([FromBody]User user)
        {
            if(user == null) return BadRequest($"User is null");

            var userResponse = await _userService.Activate(user);

            if(!string.IsNullOrEmpty(userResponse)) return NotFound(userResponse); 

            return Ok($"Successfully activated {user.LastName}");
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteUser([FromBody]User user)
        {
            if(user == null) return BadRequest($"User is null");

            var userResponse = await _userService.RemoveUser(user);

            if(!string.IsNullOrEmpty(userResponse)) return NotFound(userResponse); 

            return Ok($"Successfully deleted {user.LastName}");
        }

        #endregion

 
        #region User Roles

        [HttpGet("roles")]
        public async Task<IActionResult> UserRoles([FromBody]User user)
        {
            if(user == null) return BadRequest("User is null");

            var stg = await _userService.UserToRole(user);

            return Ok(stg);
        }

        [HttpPost("role/add")]
        public async Task<IActionResult> AddToRole([FromBody]UserRoleDto userRole)
        {
            if(userRole == null) return BadRequest("Request is null");
            if(userRole.User == null) return BadRequest("User is null");
            if(string.IsNullOrEmpty(userRole.Role)) return BadRequest("Role is null");

            var stg = await _userService.AddUserToRole(userRole.User, userRole.Role);

            if(!string.IsNullOrEmpty(stg)) return NotFound(stg);

            return Ok($"Successfully add {userRole.User.FirstName} from {userRole.Role}");
        }

        [HttpPost("role/remove")]
        public async Task<IActionResult> RemoveFromRole([FromBody]UserRoleDto userRole)
        {

            if(userRole == null) return BadRequest("Request is null");
            if(userRole.User == null) return BadRequest("User is null");
            if(string.IsNullOrEmpty(userRole.Role)) return BadRequest("Role is null");

            var stg = await _userService.RemoveUserFromRole(userRole.User, userRole.Role);

            if(!string.IsNullOrEmpty(stg)) return NotFound(stg);

            return Ok($"Successfully removes {userRole.User.FirstName} from {userRole.Role}");
        }
        #endregion

    
        
    
    }
}