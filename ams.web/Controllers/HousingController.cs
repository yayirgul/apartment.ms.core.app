using Microsoft.AspNetCore.Mvc;

namespace ams.web.Controllers
{
	public class HousingController : Controller
	{
        [Route("ams/housings")]
        public IActionResult Housings()
		{
			return View();
		}
	}
}
