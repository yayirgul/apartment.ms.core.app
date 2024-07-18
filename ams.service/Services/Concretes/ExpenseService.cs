namespace ams.service.Services.Concretes
{
    using ams.data.UnitOfWorks;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;

    public class ExpenseService : IExpenseService
    {
        private readonly IUnitOfWork Uow;
        public ExpenseService(IUnitOfWork uow)
        {
            Uow = uow;
        }

        public async Task<List<ExpenseDTO.ListView>> GetAllAsync(bool is_active)
        {
            var r = await Uow.GetRepository<Expense>().GetAllAsync(x => !x.IsDeleted && x.IsActive == is_active);

            //var pr = await Uow.GetRepository<Apartment>().GetAllAsync(x => !x.IsDeleted, y => y.User!);

            var expenses = r.ConvertAll(x => new ExpenseDTO.ListView
            {
                Id = x.Id,
                ExpenseName = x.ExpenseName,
                ExpenseCode = x.ExpenseCode,
                ExpenseDate = x.Month + "/" + x.Year,
                Month = x.Month,
                Year = x.Year,
                Amount = x.Amount,
                _Amount = x.Amount.HasValue ? x.Amount.Value.ToString("#,##0.00") : "0",
                _CreateTime = x.CreateTime != null ? x.CreateTime.ToString("dd/MM/yyyy") : "",
                IsActive = x.IsActive ? 1 : 2,
            });

            return expenses;
        }
    }
}
