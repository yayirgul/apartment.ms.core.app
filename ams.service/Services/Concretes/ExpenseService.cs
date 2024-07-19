namespace ams.service.Services.Concretes
{
    using ams.data.UnitOfWorks;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;
    using System.Globalization;

    public class ExpenseService : IExpenseService
    {
        private readonly IUnitOfWork Uow;
        public ExpenseService(IUnitOfWork uow)
        {
            Uow = uow;
        }

        public async Task AddAsync(ExpenseDTO.Add dto)
        {


            decimal amount;

            CultureInfo culture = new CultureInfo("tr-TR");
            decimal.TryParse(dto.Amount, NumberStyles.Number, culture, out amount);


          //  var amount = decimal.Parse(dto.Amount!.Replace(".", ","));

         

            var expense = new Expense()
            {
                AccountId = dto.AccountId,
                ApartmentId = dto.ApartmentId,
                ExpenseName = dto.ExpenseName,
                ExpenseCode = dto.ExpenseCode,
                Amount = amount,
                Month = dto.Month,
                Year = dto.Year,
                IsFixed = dto.IsFixed,
                IsDeleted = false,
                IsActive = true,
            };

            await Uow.GetRepository<Expense>().AddAsync(expense);
            await Uow.SaveAsync();
        }

        public async Task<string> EditAsync(ExpenseDTO.Edit dto)
        {
            var expense = await Uow.GetRepository<Expense>().GetAsync(x => !x.IsDeleted && x.Id == dto.Id);

            expense!.ExpenseName = dto.ExpenseName;
            expense.Amount = dto.Amount;
            expense.Month = dto.Month;
            expense.Year = dto.Year;
            expense.ModifiedTime = dto.ModifiedTime;
            expense.ModifiedUser = dto.ModifiedUser;

            await Uow.GetRepository<Expense>().UpdateAsync(expense);
            await Uow.SaveAsync();

            return expense.ExpenseName!;
        }

        public async Task<List<ExpenseDTO.ListView>> GetExpenses(bool is_active, Guid apartment_id, int month, int year)
        {
            var r = await Uow.GetRepository<Expense>().GetAllAsync(x => !x.IsDeleted && x.IsActive == is_active && x.ApartmentId == apartment_id && x.Month == month && x.Year == year);

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
            }).OrderBy(x => x.IsFixed).ToList();

            return expenses;
        }
    }
}
