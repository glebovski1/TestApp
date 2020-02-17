using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestApplication.Models;
using TestApplication.Services;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly UserManager<IdentityUser> _userManager;

        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly MassageStorageService _massageStorageService;

        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor, MassageStorageService massageStorageService)
        {
            _logger = logger;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
            _massageStorageService = massageStorageService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult PostTextMassage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostTextMassage(TexModel texModel)
        {
            string id  = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            
            _massageStorageService.SetMassage(id, texModel.Text);
            return Redirect("/Home/PostTextMassage");
        }
        public IActionResult GetTextMassages()
        {
            var ms = _massageStorageService.GetMassage();
            return View(ms);
        }

        public IActionResult GetTextMassagesSortedByDate()
        {
            var ms = _massageStorageService.GetMassageSortedByDate();
            return View(ms);
        }

        public IActionResult GetTextMassagesSortedById()
        {
            var ms = _massageStorageService.GetMassageSortedById();
            return View(ms);
        }
        public IActionResult GetId()
        {
            
            return Content(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
