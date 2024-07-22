﻿using ams.core.Units;
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

        [HttpPost, Route("ams/app/housing-edit")]
        public async Task<JsonResult> ExpenseEdit(HousingDTO.Add dto)
        {
            var User = HttpContext.Session.GetSession<UserDTO.User>(Unit.Constants.SESSION_USER);

            var result = new Result.ViewResult();

            dto.HousingUser = Guid.Parse("6fa95f6e-2516-49e8-9ae6-7745e7743dbf"); // TODO : Combo'dan gelecek

            Guid housing_id;

            if (Guid.TryParse(dto.Id.ToString(), out housing_id) && dto.Id != Guid.Empty)
            {
                var d = new HousingDTO.Edit()
                {
                    Id = housing_id,
                    //AccountId = (Guid)User!.AccountId!,
                    ApartmentId = dto.ApartmentId,
                    HousingName = dto.HousingName,
                    ModifiedTime = DateTime.UtcNow,
                    ModifiedUser = User!.Id
                };
                result = await HousingService.EditAsync(d);
            }
            else
            {
                dto.CreateUser = User!.Id;
                dto.AccountId = (Guid)User!.AccountId!;
                result = await HousingService.AddAsync(dto);
            }

            return Json(result);
        }

        [HttpGet, Route("ams/app/housings/{apartment_id}")]
        public async Task<JsonResult> GetTableHousings(Guid apartment_id)
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
