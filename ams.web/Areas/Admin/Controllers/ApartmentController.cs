namespace ams.web.Areas.Admin.Controllers
{
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Mvc;

    [Area("Admin")]
    public class ApartmentController : Controller
	{
		private readonly IApartmentService ApartmentService;

		public ApartmentController(IApartmentService ApartmentService)
		{
			this.ApartmentService = ApartmentService;
		}

		[HttpGet, Route("ams/app/apartments")]
        public async Task<JsonResult> ApartmentTables()
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
