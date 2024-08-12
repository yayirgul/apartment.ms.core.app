namespace ams.web.Areas.Admin.Controllers
{
    using ams.core.Units;
    using ams.entity.DTOs;
    using ams.service.Services.Abstractions;
    using ams.web.Helpers;
    using Microsoft.AspNetCore.Mvc;

    [Area("admin")]
    public class UserController : Controller
    {
        private readonly IUserService UserService;

        public UserController(IUserService UserService)
        {
            this.UserService = UserService;
        }

        [HttpPost, Route("ams/app/user/add")]
        public async Task<JsonResult> UserEdit(UserDTO.Add dto)
        {
            var User = HttpContext.Session.GetSession<UserDTO.User>(Unit.Constants.SESSION_USER);

            var result = new Result.ViewResult();
              
            Guid user_id;

            if (Guid.TryParse(dto.Id.ToString(), out user_id) && dto.Id != Guid.Empty)
            {
                var d = new UserDTO.Edit()
                {
                    Id = user_id,
                    Firstname = dto.Firstname,
                    Lastname = dto.Lastname,
                    Email = dto.Email,
                    ModifiedTime = DateTime.UtcNow,
                    ModifiedUser = User!.Id
                };
                //result = await UserService.EditAsync(d);
            }
            else
            {
                dto.CreateUser = User!.Id;
                dto.AccountId = (Guid)User!.AccountId!;
                result = await UserService.AddAsync(dto);
            }

            return Json(result);
        }

        [HttpGet, Route("ams/app/combo-housing-users/{apartment_id}")]
        public async Task<JsonResult> GetComboHousingUsers(Guid apartment_id)
        {
            return Json(await UserService.GetComboHousingUser(apartment_id));
        }

        [HttpGet, Route("ams/app/combo-users")]
        public async Task<JsonResult> GetComboUsers()
        {
            return Json(await UserService.GetComboUsers());
        }

        [HttpGet, Route("ams/app/users")]
        public async Task<JsonResult> GetUsers()
        {
            return Json(await UserService.GetUsers());
        }

        [Route("ams/users")]
        public IActionResult Users()
        {
            return View();
        }
    }
}
