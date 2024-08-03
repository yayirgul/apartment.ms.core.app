namespace ams.web.Areas.Admin.Controllers
{
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Mvc;

    public class HousingSafeController : Controller
    {
        private readonly IHousingSafeService HousingSafeService;

        public HousingSafeController(IHousingSafeService HousingSafeService)
        {
            this.HousingSafeService = HousingSafeService;
        }

        [HttpGet, Route("ams/app/housing-safe/{housing_id}")]
        public async Task<JsonResult> GetSafeHousingId(Guid housing_id)
        {
            var housing_safe = await HousingSafeService.GetSafeHousingId(housing_id);
            return Json(housing_safe); 
        }

        [Route("ams/housing-safe")]
        public async Task<IActionResult> HousingSafe()
        {
            var housing_safe = await HousingSafeService.GetHousingSafes();

            return View();
        }
    }
}
