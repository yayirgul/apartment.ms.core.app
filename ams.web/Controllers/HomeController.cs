using ams.service.Services.Abstractions;
using ams.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ams.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IApartmentService ApartmentService;

        public HomeController(ILogger<HomeController> logger, IApartmentService ApartmentService)
        {
            _logger = logger;
            this.ApartmentService = ApartmentService;
        }

        public IActionResult Index()
        {
            var r = ApartmentService.GetAllAsync();

            return View();
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