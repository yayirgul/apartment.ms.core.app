using Microsoft.AspNetCore.Mvc;

namespace ams.web.Areas.Admin.Controllers
{
	[Area("admin")]
	public class HomeController : Controller
	{
        [Route("ams/dashboard")]
        public IActionResult Index()
		{
			return View();
		}
	}
}
