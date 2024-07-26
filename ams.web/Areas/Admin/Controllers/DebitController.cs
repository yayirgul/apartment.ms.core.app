using ams.core.Units;
using ams.entity.DTOs;
using ams.service.Services.Abstractions;
using ams.service.Services.Concretes;
using ams.web.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ams.web.Areas.Admin.Controllers
{
    public class DebitController : Controller
    {
        private readonly IDebitService DebitService;
        public DebitController(IDebitService DebitService)
        {
            this.DebitService = DebitService;
        }

        [HttpPost, Route("ams/app/auto/debit/add")]
        public async Task<JsonResult> HousingEdit(DebitDTO.Add dto)
        {
            var User = HttpContext.Session.GetSession<UserDTO.User>(Unit.Constants.SESSION_USER);

            var result = new Result.ViewResult();

            Guid apartment_id;

            if (Guid.TryParse(dto.ApartmentId.ToString(), out apartment_id) && dto.ApartmentId != Guid.Empty)
            { 
                result = await DebitService.DebitAddAsync(dto.ApartmentId, User!.Id, dto.Month, dto.Year);
            } 

            return Json(result);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
