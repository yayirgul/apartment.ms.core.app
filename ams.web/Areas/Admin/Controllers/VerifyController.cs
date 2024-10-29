namespace ams.web.Areas.Admin.Controllers
{
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Mvc;

    public class VerifyController : Controller
    {
        private readonly IUserService UserService;

        public VerifyController(IUserService UserService)
        {
            this.UserService = UserService;
        }

        // TODO : Token'dan gelen "/" gibi özel karakterler yüzünden bu kısıma girmiyor.
        [HttpGet, Route("ams/app/verify-user/{key}/{token}")]
        public async Task<IActionResult> Verify(string key, string token)
        {
            //  ams/app/user/verify

            //var u = Request.Query["token"].ToString();

            if (key == null || token == null)
            {
                Redirect("/");
            }
            else
            {
                var result = await UserService.GetUserVerify(key, token);

                if (result.IsSucceed)
                {
                    TempData["user_verify"] = "Hesabınız onaylanmıştır.";
                    Redirect("/admin/auth/login");
                }

            }

            return View();
        }
    }
}
