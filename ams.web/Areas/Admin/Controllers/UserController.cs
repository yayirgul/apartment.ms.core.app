namespace ams.web.Areas.Admin.Controllers
{
    using ams.core.Units;
    using ams.entity.DTOs;
    using ams.service.Services.Abstractions;
    using ams.web.Helpers;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.WebUtilities;
    using System.Text;

    [Area("admin")]
    public class UserController : Controller
    {
        private readonly IUserService UserService;
        private readonly IMailSender MailSender;
        private readonly IHttpContextAccessor HttpContextAccessor;

        public UserController(IUserService UserService, IMailSender MailSender, IHttpContextAccessor HttpContextAccessor)
        {
            this.UserService = UserService;
            this.MailSender = MailSender;
            this.HttpContextAccessor = HttpContextAccessor;
        }

        [HttpPost, Route("ams/app/user/edit")]
        public async Task<JsonResult> UserEdit(UserDTO.Edit dto)
        {
            var User = HttpContext.Session.GetSession<UserDTO.User>(Unit.Constants.SESSION_USER);

            var result = new Result.ViewResult();

            Guid user_id;

            if (Guid.TryParse(dto.Id.ToString(), out user_id) && dto.Id != Guid.Empty)
            {
                dto.Id = user_id;
                dto.ModifiedTime = DateTime.UtcNow;
                dto.ModifiedUser = User!.Id;
                result = await UserService.EditAsync(dto);

                //var request = HttpContextAccessor!.HttpContext!.Request;
                //var url = $"{request.Scheme}://{request.Host}/ams/app/verify-user/" + result.Key + "/" + result.Token;

                //var mail = new
                //{
                //    subject = "AMS - Hesabını Onayla",
                //    body = $"Lütfen sen olduğunu doğrula. <a href='{url}'>E-Posta Adresini Doğrula</a>"
                //};

                //await MailSender.MailSendAsync(dto.Email!, mail.subject, mail.body);
            }
            else
            {

            }

            return Json(result);
        }

        [HttpPost, Route("ams/app/user/add")]
        public async Task<JsonResult> UserAdd(UserDTO.Add dto)
        {
            var User = HttpContext.Session.GetSession<UserDTO.User>(Unit.Constants.SESSION_USER);

            var result = new Result.ViewResult();

            dto.CreateUser = User!.Id;
            dto.AccountId = (Guid)User!.AccountId!;
            result = await UserService.AddAsync(dto);

            if (result.IsSucceed)
            {
                var request = HttpContextAccessor!.HttpContext!.Request;
                //var url = $"{request.Scheme}://{request.Host}/ams/app/user/verify/" + result.Key + "?token=" + HttpUtility.UrlEncode(result.Token);

                var token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(result.Token));
                var url = $"{request.Scheme}://{request.Host}/ams/app/user/verify/" + result.Key + "?token=" + token;

                var mail = new
                {
                    subject = "AMS - Hesabını Onayla",
                    body = $"Lütfen sen olduğunu doğrula. <a href='{url}'>E-Posta Adresini Doğrula</a>"
                };

                await MailSender.MailSendAsync(dto.Email!, mail.subject, mail.body);
            }

            return Json(result);
        }

        [HttpGet, Route("ams/app/combo-housing-user/{housing_id}")]
        public async Task<JsonResult> GetComboHousingUser(Guid housing_id)
        {
            return Json(await UserService.GetComboHousingUser(housing_id));
        }

        [HttpGet, Route("ams/app/combo-housing-users/{apartment_id}")]
        public async Task<JsonResult> GetComboHousingUsers(Guid apartment_id)
        {
            return Json(await UserService.GetComboHousingUsers(apartment_id));
        }

        [HttpGet, Route("ams/app/combo-users")]
        public async Task<JsonResult> GetComboUsers()
        {
            return Json(await UserService.GetComboUsers());
        }

        [HttpGet, Route("ams/app/user/{user_id}")]
        public async Task<JsonResult> GetUser(Guid user_id)
        {
            return Json(await UserService.GetUser(user_id));
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
