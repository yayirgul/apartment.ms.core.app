using Microsoft.AspNetCore.Mvc;

namespace ams.web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ExpenseController : Controller
    {
        [Route("ams/expenses")]
        public IActionResult Expenses()
        {
            return View();
        }
    }
}
