namespace ams.web.Areas.Admin.Controllers
{
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Mvc;

    [Area("admin")]
    public class ApartmentController : Controller
	{
		private readonly IApartmentService ApartmentService;

		public ApartmentController(IApartmentService ApartmentService)
		{
			this.ApartmentService = ApartmentService;
		}

        [HttpGet, Route("ams/app/combo-apartments")]
        public async Task<JsonResult> GetComboApartments()
        {
            var apartments = await ApartmentService.GetComboApartment(true);
            return Json(apartments);
        }

        [HttpGet, Route("ams/app/apartments")]
        public async Task<JsonResult> ApartmentTables()
		{
			var apartments = await ApartmentService.GetAllAsync();
			return Json(apartments);
		}

		[Route("ams/apartments")]
		public IActionResult Apartments()
		{
			return View();
		}
	}
}
