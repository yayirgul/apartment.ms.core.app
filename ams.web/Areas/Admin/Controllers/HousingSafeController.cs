namespace ams.web.Areas.Admin.Controllers
{
    using ams.core.Units;
    using ams.entity.DTOs;
    using ams.service.Services.Abstractions;
    using ams.web.Helpers;
    using Microsoft.AspNetCore.Mvc;

    [Area("admin")]
    public class HousingSafeController : Controller
    {
        private readonly IHousingSafeService HousingSafeService;

        public HousingSafeController(IHousingSafeService HousingSafeService)
        {
            this.HousingSafeService = HousingSafeService;
        }

        [HttpPost, Route("ams/app/housing-safe/amount-edit")]
        public async Task<JsonResult> AmountEdit(HousingSafeDTO.Edit dto)
        {
            var User = HttpContext.Session.GetSession<UserDTO.User>(Unit.Constants.SESSION_USER);

            var result = new Result.ViewResult();

            Guid housing_id;

            if (Guid.TryParse(dto.HousingId.ToString(), out housing_id) && dto.HousingId != Guid.Empty)
            {
                dto.ModifiedUser = User!.Id;
                dto.ModifiedTime = DateTime.UtcNow;
                dto.ModifiedUser = User!.Id;
                result = await HousingSafeService.AmountEdit(dto);
            }

            return Json(result);
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
