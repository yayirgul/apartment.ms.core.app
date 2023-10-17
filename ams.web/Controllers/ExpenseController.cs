using Microsoft.AspNetCore.Mvc;

namespace ams.web.Controllers
{
	public class ExpenseController : Controller
	{
		[Route("ams/expenses")]
		public IActionResult Expenses()
		{
			return View();
		}
	}
}
