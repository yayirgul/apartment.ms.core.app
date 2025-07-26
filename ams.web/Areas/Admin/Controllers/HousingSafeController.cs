namespace ams.web.Areas.Admin.Controllers
{
    using ams.service.Services.Abstractions;
    using ams.service.Services.Concretes;
    using Microsoft.AspNetCore.Mvc;

    [Area("admin")]
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

        [HttpGet, Route("ams/app/housing-safes/{apartment_id}")]
        public async Task<JsonResult> GetHousings(Guid apartment_id)
        {
            var housing_safe = await HousingSafeService.GetHousingSafes(apartment_id);
            return Json(housing_safe);
        }


        [Route("ams/housing-safe")]
        public IActionResult HousingSafe()
        {
            return View();
        }
    }
}
