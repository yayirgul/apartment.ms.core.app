namespace ams.web.Areas.Admin.Controllers
{
	using ams.core.Units;
	using ams.entity.DTOs;
	using ams.service.Services.Abstractions;
	using ams.service.Services.Concretes;
	using ams.web.Helpers;
	using Humanizer;
	using Microsoft.AspNetCore.Mvc;

	[Area("admin")]
	public class HomeController : Controller
	{
		private readonly IDashboardService DashboardService;

		public HomeController(IDashboardService DashboardService)
		{
			this.DashboardService = DashboardService;
		}

		[Route("ams/dashboard/analysis/{apartment_id}/{type}/{year}")]
		public async Task<JsonResult> GetDashboardAnalysis(Guid apartment_id, string type, int year)
		{
			var user = HttpContext.Session.GetSession<UserDTO.User>(Unit.Constants.SESSION_USER);

			var analysis = new Result.ListResult<DashboardDTO.Expense>();

			if (user == null)
			{
				analysis.IsSucceed = true;
				analysis.Statuses = "x-timeout";
			}
			else
			{
				Guid account_id;

				if (Guid.TryParse(user!.AccountId.ToString(), out account_id))
				{
					analysis = await DashboardService.GetExpenseChart(user!.AccountId, apartment_id, year);
				}
				else
				{
					analysis.IsSucceed = true;
					analysis.Statuses = "x-timeout";
				}
			}

			return Json(analysis);
		}

		[Route("ams/dashboard")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
