namespace ams.web.Areas.Admin.Controllers
{
    using ams.core.Units;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.web.Helpers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    [Area("admin")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> UserManager;
        private readonly SignInManager<AppUser> SignInManager;

        public AuthController(UserManager<AppUser> UserManager, SignInManager<AppUser> SignInManager)
        {
            this.UserManager = UserManager;
            this.SignInManager = SignInManager;
        }

        [Authorize]
        [Route("ams/auth/access-denied")]
        public IActionResult Denied()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = "" });
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(UserDTO.Login dto)
        {
            if (ModelState.IsValid)
            {
                var user = await UserManager.FindByEmailAsync(dto.Email); // E-Mail kontrolü

                if (user != null)
                {
                    await SignInManager.SignOutAsync();

                    if (!await UserManager.IsEmailConfirmedAsync(user))
                    {
                        ModelState.AddModelError("", "Hesabınızın onaylanması gerekiyor.");
                        return View(dto);
                    }

                    var result = await SignInManager.PasswordSignInAsync(user, dto.Password, dto.RememberMe, false); // Parola ve beni hatırla kontrolü

                    if (result.Succeeded)
                    {
                        // TODO : Kullanıcının girmiş olduğu hatalı girişlerinin sayısını sıfırlıyorum. Adet sayısını "Program.cs" de belirledim.
                        await UserManager.ResetAccessFailedCountAsync(user);

                        // TODO : Kullanıcının bitiş süresini sıfırlıyorum.
                        await UserManager.SetLockoutEndDateAsync(user, null);

                        var session_user = new UserDTO.User()
                        {
                            Id = user.Id,
                            AccountId = (Guid)user.AccountId!,
                            Firstname = user.Firstname,
                            Lastname = user.Lastname,
                            Email = dto.Email,
                        };

                        HttpContext.Session.SetSession<UserDTO.User>(Unit.Constants.SESSION_USER, session_user);

                        return RedirectToAction("Index", "Home", new { Area = "Admin" });
                    }
                    else if (result.IsLockedOut)
                    {
                        var lockout_date = await UserManager.GetLockoutEndDateAsync(user);
                        var time_left = lockout_date.Value - DateTime.UtcNow;
                        ModelState.AddModelError("", $"Hesabınız kitlendi, Lütfen {time_left} dakika sonra deneyiniz?");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Parolanız hatalı...");
                    }

                }
                else
                {
                    ModelState.AddModelError("", "E-Posta adresine bağlı hesap bulunamadı...");
                }
            }
            else
                return View(dto);

            return View(dto);
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
