using ams.entity.DTOs;
using ams.entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ams.web.Areas.Admin.Components
{
    [Area("admin")]
    public class HeaderViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> UserManager;
        public HeaderViewComponent(UserManager<AppUser> UserManager)
        {
            this.UserManager = UserManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var logged = await UserManager.GetUserAsync(HttpContext.User); 

            var user = new UserDTO.Logged
            {
                Id = logged!.Id,
                Firstname = logged!.Firstname!,
                Lastname = logged!.Lastname!,
                Email = logged!.Email!,
				EmailConfirmed = logged!.EmailConfirmed!,
				PhoneNumber = logged!.PhoneNumber!,
				AccessFailedCount = logged!.AccessFailedCount!,
				Role = string.Join("", await UserManager.GetRolesAsync(logged!)),
            };

			return await Task.FromResult(View(user));
        }
    }
}
