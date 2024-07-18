namespace ams.web.Areas.Admin.Controllers
{
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Mvc;

    [Area("admin")]
    public class ExpenseController : Controller
    {
        private readonly IExpenseService ExpenseService;

        public ExpenseController(IExpenseService ExpenseService)
        {
            this.ExpenseService = ExpenseService;
        }

        [HttpGet, Route("ams/app/expense-edit")]
        public async Task<JsonResult> ExpenseEdit()
        {
            return Json("");
        }

        [HttpGet, Route("ams/app/expenses")]
        public async Task<JsonResult> ExpenseTable()
        {
            var expenses = await ExpenseService.GetAllAsync(true);
            return Json(expenses);
        }

        [Route("ams/expenses")]
        public IActionResult Expenses()
        {
            return View();
        }
    }
}
