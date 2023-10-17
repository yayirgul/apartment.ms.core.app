using Microsoft.AspNetCore.Mvc;

namespace ams.web.Controllers
{
	public class ApartmentController : Controller
	{
        [Route("ams/apartments")]
        public IActionResult Apartments()
		{
			return View();
		}
	}
}
