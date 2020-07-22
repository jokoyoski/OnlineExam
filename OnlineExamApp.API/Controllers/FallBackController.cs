


using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using OnlineExamApp.API.Dto;
using System;
using OnlineExamApp.API.Interfaces;
using System.Security.Claims;
using System.IO;

namespace OnlineExamApp.API.Controllers
{


    public class FallBackController : Controller
    {

        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"), "text/HTML");
        }
    }
}