namespace ams.web.Areas.Admin.Controllers
{
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Mvc;

    [Area("admin")]
    public class HousingSafeMovementController : Controller
    {
        private readonly IHousingSafeMovement HousingSafeMovement;
        public HousingSafeMovementController(IHousingSafeMovement HousingSafeMovement)
        {
            this.HousingSafeMovement = HousingSafeMovement;
        }

        [HttpGet, Route("ams/app/housing-safe-movement/{housing_id}/{month}/{year}")]
        public async Task<JsonResult> GetSafeHousingId(Guid housing_id, int month, int year)
        {
            var movement = await HousingSafeMovement.GetMovementHousingId(housing_id, month, year);
            return Json(movement);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
