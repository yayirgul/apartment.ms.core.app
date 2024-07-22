namespace ams.web.Areas.Admin.Controllers
{
    using ams.core.Units;
    using ams.entity.DTOs;
    using ams.service.Services.Abstractions;
    using ams.web.Helpers;
    using Microsoft.AspNetCore.Mvc;

    [Area("admin")]
    public class ExpenseController : Controller
    {
        private readonly IExpenseService ExpenseService;

        public ExpenseController(IExpenseService ExpenseService)
        {
            this.ExpenseService = ExpenseService;
        }

        [HttpPost, Route("ams/app/expense-edit")]
        public async Task<JsonResult> ExpenseEdit(ExpenseDTO.Add dto)
        {
            var User = HttpContext.Session.GetSession<UserDTO.User>(Unit.Constants.SESSION_USER);

            var result = new Result.ViewResult();

            Guid expense_id;

            if (Guid.TryParse(dto.Id.ToString(), out expense_id) && dto.Id != Guid.Empty)
            {
                var d = new ExpenseDTO.Edit()
                {
                    Id = expense_id,
                    AccountId = (Guid)User!.AccountId!,
                    ApartmentId = dto.ApartmentId,
                    ExpenseName = dto.ExpenseName,
                    Amount = dto.Amount,
                    Month = dto.Month,
                    Year = dto.Year,
                    ModifiedTime = DateTime.UtcNow,
                    ModifiedUser = User!.Id
                };
                result = await ExpenseService.EditAsync(d);
            }
            else
            {
                dto.CreateUser = User!.Id;
                dto.AccountId = (Guid)User!.AccountId!;
                dto.ExpenseCode = "01" + dto.Month + dto.Year;
                result = await ExpenseService.AddAsync(dto);
            }
            
            return Json(result);
        }

        [HttpGet, Route("ams/app/expense/{expense_id}")]
        public async Task<JsonResult> GetExpense(Guid expense_id)
        {
            var expenses = await ExpenseService.GetExpense(expense_id);
            return Json(expenses);
        }

        [HttpGet, Route("ams/app/expenses/{apartment_id}/{month}/{year}")]
        public async Task<JsonResult> GetTableExpenses(Guid apartment_id, int month, int year)
        {
            var expenses = await ExpenseService.GetExpenses(apartment_id, month, year);
            return Json(expenses);
        }

        [Route("ams/expenses")]
        public IActionResult Expenses()
        {
            return View();
        }
    }
}
