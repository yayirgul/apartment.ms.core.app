namespace ams.web.Areas.Admin.Controllers
{
    using ams.core.Units;
    using ams.entity.DTOs;
    using ams.service.Services.Abstractions;
    using ams.web.Helpers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Area("admin")]
    public class DebitController : Controller
    {
        private readonly IDebitService DebitService;

        public DebitController(IDebitService DebitService)
        {
            this.DebitService = DebitService;
        }

        [HttpPost, Route("ams/app/debit/pays")]
        public async Task<JsonResult> DebitPay(DebitDTO.Pays dto)
        {
            var User = HttpContext.Session.GetSession<UserDTO.User>(Unit.Constants.SESSION_USER);

            var result = new Result.ViewResult();

            //Guid debit_id;

            //if (Guid.TryParse(dto.DebitId.ToString(), out debit_id) && dto.DebitId != Guid.Empty)
            //{
            //    dto.CreateUser = User!.Id;
            //    dto.ModifiedTime = DateTime.UtcNow;
            //    dto.ModifiedUser = User!.Id;

            //}

            dto.CreateUser = User!.Id;
            dto.ModifiedTime = DateTime.UtcNow;
            dto.ModifiedUser = User!.Id;

            result = await DebitService.DebitPays(dto);

            return Json(result);
        }

        [HttpPost, Route("ams/app/debit/pay")]
        public async Task<JsonResult> DebitPay(DebitDTO.Pay dto)
        {
            var User = HttpContext.Session.GetSession<UserDTO.User>(Unit.Constants.SESSION_USER);

            var result = new Result.ViewResult();

            Guid debit_id;

            if (Guid.TryParse(dto.DebitId.ToString(), out debit_id) && dto.DebitId != Guid.Empty)
            {
                dto.CreateUser = User!.Id;
                dto.ModifiedTime = DateTime.UtcNow;
                dto.ModifiedUser = User!.Id;
                result = await DebitService.DebitPay(dto);
            }

            return Json(result);
        }

        [HttpPost, Route("ams/app/auto/debit/add")]
        public async Task<JsonResult> DebitAdd(DebitDTO.Add dto)
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

        [HttpGet, Route("ams/app/debit/unpaid/{housing_id}")]
        public async Task<JsonResult> GetDebitUnpaids(Guid housing_id)
        {
            var unpaid = await DebitService.GetDebitUnpaids(housing_id);
            return Json(unpaid);
        }

        [HttpGet, Route("ams/app/debits/{apartment_id}/{month}/{year}")]
        public async Task<JsonResult> GetDebits(Guid apartment_id, int month, int year)
        {
            var debits = await DebitService.GetDebits(apartment_id, month, year);
            return Json(debits);
        }

        [Route("ams/debits")]
        [Authorize(Roles = $"{Helper.Role.ADMIN}")]
        public IActionResult Debits()
        {
            return View();
        }
    }
}
