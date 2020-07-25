using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SystemSettingsController : ControllerBase
    {
        private readonly ICacheService _cacheService;

        public SystemSettingsController(ICacheService cacheService)
        {
            this._cacheService = cacheService;
        }

        [HttpPost("resync")]
        public async Task<IActionResult> Resync()
        {
            _cacheService.RemoveAllFromCache();
            return Ok("Resynce Successful");
        }
    
        
    
    }
}