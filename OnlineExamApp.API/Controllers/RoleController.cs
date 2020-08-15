
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;

namespace OnlineExamApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            this._roleService = roleService;
        }


        #region  Roles Management CRUD

        [HttpGet]
        public async Task<IActionResult> Roles()
        {
            var roles = await _roleService.Roles();

            return Ok(roles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRole(int id)
        {

            if(id <= 0) return BadRequest($"{id} is less than or equal 0");

            var role = await _roleService.GetRole(id);

            return Ok(role);
        }
        
        [HttpPost("add")]
        public async Task<IActionResult> AddRole([FromBody]Role role)
        {

            if(role == null) return BadRequest();

            var stg = await _roleService.AddRole(role);

            if(!string.IsNullOrEmpty(stg)) return NotFound(stg);
            
            return Created("role/add", role);
        }
        
        [HttpPost("edit")]
        public async Task<IActionResult> EditRole([FromBody]Role role)
        {
            if(role == null) return BadRequest();

            var stg = await _roleService.EditRole(role);

            if(!string.IsNullOrEmpty(stg)) return NotFound(stg);
            
            return Ok($"Successfully edited {role.Name}");
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteRoelce([FromBody]Role role)
        {
             if(role == null) return BadRequest();

            var stg = await _roleService.RemoveRole(role);

            if(!string.IsNullOrEmpty(stg)) return NotFound(stg);
            
            return Ok($"Successfully deleted {role.Name}");
        }

        #endregion

    }
}