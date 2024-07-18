namespace ams.web.Areas.Admin.Controllers
{
    using ams.entity.DTOs;
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

        [HttpPost, Route("ams/app/expense-edit")]
        public async Task<JsonResult> ExpenseEdit(ExpenseDTO.Add dto)
        {
            Guid expense_id;

            if (Guid.TryParse(dto.Id.ToString(), out expense_id) && dto.Id != Guid.Empty)
            {
                var d = new ExpenseDTO.Edit()
                {
                    Id = expense_id,
                    AccountId = Guid.Parse("db72e0e2-3201-414f-9753-190466e024f3"), // Session'dan alınacak
                    ApartmentId = dto.ApartmentId,
                    Month = dto.Month,
                    Year = dto.Year,
                    ModifiedTime = DateTime.UtcNow,
                    ModifiedUser = Guid.Parse("6fa95f6e-2516-49e8-9ae6-7745e7743dbf") // Session'dan alınacak
                };

                var r = await ExpenseService.EditAsync(d);
            }
            else
            {
                //dto.CreateUser = Helper.Sessions.UserViewModel.Id;
                dto.AccountId = Guid.Parse("db72e0e2-3201-414f-9753-190466e024f3");
                dto.ExpenseCode = "01" + dto.Month + dto.Year;
                await ExpenseService.AddAsync(dto);
            }
            
            return Json("");
        }

        [HttpGet, Route("ams/app/expenses")]
        public async Task<JsonResult> ExpenseTable()
        {
            var expenses = await ExpenseService.GetExpenses(true);
            return Json(expenses);
        }

        [Route("ams/expenses")]
        public IActionResult Expenses()
        {
            return View();
        }
    }
}
