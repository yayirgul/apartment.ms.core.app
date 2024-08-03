using ams.core.Units;
using ams.entity.DTOs;
using ams.service.Services.Abstractions;
using ams.service.Services.Concretes;
using ams.web.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ams.web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HousingController : Controller
    {
        private readonly IHousingService HousingService;

        public HousingController(IHousingService HousingService)
        {
            this.HousingService = HousingService;
        }

        [HttpPost, Route("ams/app/housing/add")]
        public async Task<JsonResult> HousingEdit(HousingDTO.Add dto)
        {
            var User = HttpContext.Session.GetSession<UserDTO.User>(Unit.Constants.SESSION_USER);

            var result = new Result.ViewResult();

            Guid housing_id;

            if (Guid.TryParse(dto.Id.ToString(), out housing_id) && dto.Id != Guid.Empty)
            {
                var d = new HousingDTO.Edit()
                {
                    Id = housing_id,
                    //AccountId = (Guid)User!.AccountId!,
                    ApartmentId = dto.ApartmentId,
                    HousingName = dto.HousingName,
                    HousingNo = dto.HousingNo,
                    ModifiedTime = DateTime.UtcNow,
                    ModifiedUser = User!.Id,
                    HousingUser = dto.HousingUser,
                };
                result = await HousingService.EditAsync(d);
            }
            else
            {
                dto.CreateUser = User!.Id;
                dto.AccountId = (Guid)User!.AccountId!;
                dto.HousingUser = dto.HousingUser;
                result = await HousingService.AddAsync(dto);
            }

            return Json(result);
        }

        [HttpGet, Route("ams/app/housing/{housing_id}")]
        public async Task<JsonResult> GetHousing(Guid housing_id)
        {
            return Json(await HousingService.GetHousing(housing_id));
        }

        [HttpGet, Route("ams/app/housings/{apartment_id}")]
        public async Task<JsonResult> GetHousings(Guid apartment_id)
        {
            var housing = await HousingService.GetHousings(apartment_id);
            return Json(housing);
        }

        [Route("ams/housings")]
        public IActionResult Housings()
        {
            return View();
        }
    }
}
