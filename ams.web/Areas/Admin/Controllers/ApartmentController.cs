namespace ams.web.Areas.Admin.Controllers
{
    using ams.core.Units;
    using ams.entity.DTOs;
    using ams.service.Services.Abstractions;
    using ams.web.Helpers;
    using Microsoft.AspNetCore.Mvc;

    [Area("admin")]
    public class ApartmentController : Controller
	{
		private readonly IApartmentService ApartmentService;

		public ApartmentController(IApartmentService ApartmentService)
		{
			this.ApartmentService = ApartmentService;
		}

        [HttpPost, Route("ams/app/apartment/add")]
        public async Task<JsonResult> ApartmentEdit(ApartmentDTO.Add dto)
        {
            var User = HttpContext.Session.GetSession<UserDTO.User>(Unit.Constants.SESSION_USER);

            var result = new Result.ViewResult();

            Guid apartment_id;

            if (Guid.TryParse(dto.Id.ToString(), out apartment_id) && dto.Id != Guid.Empty)
            {
                var d = new ApartmentDTO.Edit()
                {
                    Id = apartment_id,
                    ApartmentName = dto.ApartmentName,
                    ModifiedTime = DateTime.UtcNow,
                    ModifiedUser = User!.Id,
                };
                result = await ApartmentService.EditAsync(d);
            }
            else
            {
                dto.CreateUser = User!.Id;
                dto.AccountId = (Guid)User!.AccountId!;
                result = await ApartmentService.AddAsync(dto);
            }

            return Json(result);
        }

        [HttpGet, Route("ams/app/combo-apartments")]
        public async Task<JsonResult> GetComboApartments()
        {
            var apartments = await ApartmentService.GetComboApartment(true);
            return Json(apartments);
        }

        [HttpGet, Route("ams/app/apartment/{apartment_id}")]
        public async Task<JsonResult> GetHousing(Guid apartment_id)
        {
            return Json(await ApartmentService.GetApartment(apartment_id));
        }

        [HttpGet, Route("ams/app/apartments")]
        public async Task<JsonResult> ApartmentTables()
		{
			var apartments = await ApartmentService.GetApartments();
			return Json(apartments);
		}

		[Route("ams/apartments")]
		public IActionResult Apartments()
		{
			return View();
		}
	}
}
