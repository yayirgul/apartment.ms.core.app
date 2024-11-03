namespace ams.web.Areas.Admin.Controllers
{
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.WebUtilities;
    using System.Text;

    [Area("admin")]
    public class VerifyController : Controller
    {
        private readonly IUserService UserService;
        private readonly IHttpContextAccessor HttpContextAccessor;

        public VerifyController(IUserService UserService, IHttpContextAccessor HttpContextAccessor)
        {
            this.UserService = UserService;
            this.HttpContextAccessor = HttpContextAccessor;
        }

        //[AllowAnonymous]
        [HttpGet, Route("ams/app/user/verify/{key}")]
        public async Task<IActionResult> UserVerify(string key)
        {
            var request = HttpContextAccessor!.HttpContext!.Request;

            //var token = HttpUtility.UrlDecode(Request.Query["token"]);
            //token = token.Replace(" ", "+");

            var token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(Request.Query["token"].ToString()));

            if (key == null || token == null)
            {
                return Redirect("/");
            }
            else
            {
                var result = await UserService.GetUserVerify(key, token);

                if (result.IsSucceed)
                {
                    TempData["user_verify"] = "Hesabınız onaylanmıştır.";
                    
                    var url = $"{request.Scheme}://{request.Host}/Admin/auth/login";
                    return Redirect(url);
                }
                else
                {
                    Redirect("/admin/auth/login");
                }

            }

            return View();
        }
    }
}
