namespace ams.web.Areas.Admin.Controllers
{
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Mvc;

    [Area("admin")]
    public class UserController : Controller
    {
        private readonly IUserService UserService;

        public UserController(IUserService UserService)
        {
            this.UserService = UserService;
        }

        [HttpGet, Route("ams/app/combo-users")]
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
