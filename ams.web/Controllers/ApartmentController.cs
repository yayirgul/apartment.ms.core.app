using Microsoft.AspNetCore.Mvc;

namespace ams.web.Controllers
{
	public class ApartmentController : Controller
	{
		public IActionResult Apartments()
		{
			return View();
		}
	}
}
