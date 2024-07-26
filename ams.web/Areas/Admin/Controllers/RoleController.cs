namespace ams.web.Areas.Admin.Controllers
{
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Mvc;

    public class RoleController : Controller
    {
        private readonly IRoleService RoleService;
        public RoleController(IRoleService RoleService)
        {
            this.RoleService = RoleService;
        }

        [HttpGet, Route("ams/app/combo-roles")]
        public async Task<JsonResult> GetComboRoles()
        { 
            return Json(await RoleService.GetComboRoles());
        }

        [Route("ams/roles")]
        public IActionResult Roles()
        {
            return View();
        }
    }
}
