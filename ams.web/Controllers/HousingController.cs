using Microsoft.AspNetCore.Mvc;

namespace ams.web.Controllers
{
	public class HousingController : Controller
	{
		public IActionResult Housings()
		{
			return View();
		}
	}
}
