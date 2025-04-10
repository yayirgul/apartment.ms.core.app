﻿namespace ams.service.Services.Concretes
{
    using ams.core.Units;
    using ams.data.UnitOfWorks;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;
    using System.Globalization;

    public class ExpenseService : IExpenseService
    {
        private readonly IUnitOfWork Uow;
        private readonly CultureInfo Culture;

        public ExpenseService(IUnitOfWork uow)
        {
            Uow = uow;
            Culture = new CultureInfo("tr-TR");
        }

        public async Task<Result.ViewResult<ExpenseDTO.Calc>> GetExpenseDebitCalc(Guid apartment_id, int month, int year)
        {
            var ls_expense = new List<Expense>();

            var lse = await Uow.GetRepository<Expense>().GetAllAsync(x => !x.IsDeleted && x.IsActive == true && x.ApartmentId == apartment_id && x.Month == month && x.Year == year);

            var lsf = await Uow.GetRepository<Expense>().GetAllAsync(x => !x.IsDeleted && x.IsActive == true && x.ApartmentId == apartment_id && x.Year == year && x.IsFixed == true);

            ls_expense = lse.Concat(lsf).ToList();

            var view = new Result.ViewResult<ExpenseDTO.Calc>();

            if (ls_expense.Count() > 0)
            {
                var ls_housing_count = await Uow.GetRepository<Housing>().CountAsync(x => !x.IsDeleted && x.IsActive == true && x.ApartmentId == apartment_id);

                if (ls_housing_count > 0)
                {
                    var ls_expense_calc = ls_expense.Sum(x => x.Amount);
                    var calc = ls_expense_calc / ls_housing_count;

                    var vw = new ExpenseDTO.Calc()
                    {
                        TotalAmount = ls_expense_calc.HasValue ? ls_expense_calc.Value.ToString("N", Culture) : "0",
                        CalcAmount = calc.HasValue ? calc.Value.ToString("N2", Culture) : "0"
                    };

                    view.View = vw;
                    view.IsSucceed = true;
                    view.Statuses = "x-calc";
                }
                else
                {
                    view.IsSucceed = true;
                    view.Statuses = "x-housing";
                }
            }
            else
            {
                view.IsSucceed = true;
                view.Statuses = "x-fail";
            } 

            return view;
        }

        public async Task<Result.ViewResult> AddAsync(ExpenseDTO.Add dto)
        {
            decimal amount;
            decimal.TryParse(dto.Amount, NumberStyles.Number, Culture, out amount);

            var expense = new Expense()
            {
                AccountId = dto.AccountId,
                ApartmentId = dto.ApartmentId,
                ExpenseName = dto.ExpenseName,
                ExpenseCode = dto.ExpenseCode,
                CreateUser = dto.CreateUser,
                Amount = amount,
                Month = dto.Month,
                Year = dto.Year,
                IsFixed = dto.IsFixed,
                IsDeleted = false,
                IsActive = true,
            };

            await Uow.GetRepository<Expense>().AddAsync(expense);
            var result = await Uow.SaveAsync();

            var view = new Result.ViewResult();

            switch (result)
            {
                case 1:
                    view.IsSucceed = true;
                    view.Statuses = "x-add";
                    break;
                case 0:
                    view.IsSucceed = true;
                    view.Statuses = "x-fail";
                    break;
            }

            return view;
        }

        public async Task<Result.ViewResult> EditAsync(ExpenseDTO.Edit dto)
        {
            var expense = await Uow.GetRepository<Expense>().GetAsync(x => !x.IsDeleted && x.Id == dto.Id);
            
            decimal amount;
            decimal.TryParse(dto.Amount, NumberStyles.Number, Culture, out amount);

            expense!.ExpenseName = dto.ExpenseName;
            expense.Amount = amount;
            expense.Month = dto.Month;
            expense.Year = dto.Year;
            expense.ModifiedTime = dto.ModifiedTime;
            expense.ModifiedUser = dto.ModifiedUser;
            expense.IsFixed = dto.IsFixed;

            await Uow.GetRepository<Expense>().UpdateAsync(expense);
            var result = await Uow.SaveAsync();

            var view = new Result.ViewResult();

            switch (result)
            {
                case 1:
                    view.IsSucceed = true;
                    view.Statuses = "x-edit";
                    break;
                case 0:
                    view.IsSucceed = true;
                    view.Statuses = "x-fail";
                    break;
            }

            return view;
        }

        public async Task<ExpenseDTO.Detail> GetExpense(Guid expense_id)
        {
            var view = await Uow.GetRepository<Expense>().GetAsync(x => !x.IsDeleted && x.Id == expense_id);
             
            decimal amount;

            //var culture = new CultureInfo("tr-TR");
            //decimal.TryParse(view!.Amount.ToString(), NumberStyles.Number, culture, out amount);

            decimal.TryParse(view!.Amount.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out amount);

            var expense = new ExpenseDTO.Detail()
            {
                Id = view!.Id,
                ApartmentId = view.ApartmentId,
                ExpenseName = view!.ExpenseName,
                Month = view!.Month,
                Year = view!.Year,
                Amount = view.Amount,
                //_Amount = view.Amount.HasValue ? view.Amount!.Value.ToString("#,##0.00") : ""
                _Amount = view.Amount.HasValue ? view.Amount.Value.ToString("N2", Culture) : "",
                IsFixed = view.IsFixed
            };

            return expense;
        }

        public async Task<List<ExpenseDTO.Table>> GetExpenses(Guid apartment_id, int month, int year)
        {
            var list = new List<Expense>();

            // TODO : Annual variable expenses
            var ls = await Uow.GetRepository<Expense>().GetAllAsync(x => !x.IsDeleted && x.ApartmentId == apartment_id && x.Month == month && x.Year == year && x.IsFixed == false, y => y.CreateTheUser!, z => z.ModifiedTheUser!);

            // TODO : Annual fixed expenses 
            var lsf = await Uow.GetRepository<Expense>().GetAllAsync(x => !x.IsDeleted && x.ApartmentId == apartment_id && x.Year == year && x.IsFixed == true, y => y.CreateTheUser!, z => z.ModifiedTheUser!);
            
            list = ls.Concat(lsf).ToList(); 

            var expenses = list.ConvertAll(x => new ExpenseDTO.Table
            {
                Id = x.Id,
                ExpenseName = x.ExpenseName,
                ExpenseCode = x.ExpenseCode,
                ExpenseDate = x.Month + "/" + x.Year,
                Month = x.Month,
                Year = x.Year,
                Amount = x.Amount,
                //_Amount = x.Amount.HasValue ? x.Amount.Value.ToString("#,##0.00") : "0",
                _Amount = x.Amount.HasValue ? x.Amount.Value.ToString("N2", Culture) : "0",
                _CreateTime = x.CreateTime != null ? x.CreateTime.ToString("dd/MM/yyyy") : "",
                IsActive = x.IsActive ? 1 : 2,
                CreateUser = x.CreateTheUser != null ? x.CreateTheUser.Firstname + " " + x.CreateTheUser.Lastname : "-",
                UpdateUser = x.ModifiedTheUser != null ? x.ModifiedTheUser.Firstname + " " + x.ModifiedTheUser.Lastname : "-",
                IsFixed = x.IsFixed
            }).OrderBy(x => x.IsFixed).ToList();

            return expenses;
        }
    }
}
