namespace ams.web.Controllers
{
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Mvc;

    public class ApartmentController : Controller
	{
        private readonly IApartmentService ApartmentService;

        public ApartmentController(IApartmentService ApartmentService)
        {
            this.ApartmentService = ApartmentService;
        }

        [Route("ams/app/apartments")]
        public async Task<JsonResult> Apartment()
        {
            var r = await ApartmentService.GetAllAsync();

            return Json(r);
        }

        [Route("ams/apartments")]
        public IActionResult Apartments()
		{
			return View();
		}
	}
}
