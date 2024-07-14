using Microsoft.AspNetCore.Mvc;

namespace ams.web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HousingController : Controller
    {
        [Route("ams/housings")]
        public IActionResult Housings()
        {
            return View();
        }
    }
}
