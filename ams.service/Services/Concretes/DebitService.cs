namespace ams.service.Services.Concretes
{
    using ams.core.Units;
    using ams.data.UnitOfWorks;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;
    using System.Globalization;

    public class DebitService : IDebitService
    {
        private readonly IUnitOfWork Uow;
        private readonly CultureInfo Culture;

        public DebitService(IUnitOfWork uow)
        {
            Uow = uow;
            Culture = new CultureInfo("tr-TR");
        }

        public async Task<Result.ViewResult> DebitAddAsync(Guid apartment_id, Guid create_user, int month, int year)
        {
            var ls_expense = await Uow.GetRepository<Expense>().GetAllAsync(x => !x.IsDeleted && x.IsActive == true && x.ApartmentId == apartment_id && x.Month == month && x.Year == year);

            var view = new Result.ViewResult();

            if (ls_expense.Count() > 0)
            {
                // Toplam 10 adet konut gelecek
                var ls_housing = await Uow.GetRepository<Housing>().GetAllAsync(x => !x.IsDeleted && x.IsActive == true && x.ApartmentId == apartment_id);

                if (ls_housing.Count() > 0)
                {
                    var ls_expense_calc = ls_expense.Sum(x => x.Amount);
                    var amount = ls_expense_calc / ls_housing.Count();
                    
                    foreach (var item in ls_housing)
                    {

                        var debit = new Debit()
                        {
                            AccountId = item.AccountId,
                            ApartmentId = (Guid)item.ApartmentId!,
                            HousingId = item.Id,
                            Amount = amount,
                            DebitUser = item.HousingUser,
                            CreateUser = create_user,
                            _Month = month,
                            _Year = year,
                            ExpenseCode = month + "" + year,
                            Paid = false,
                            IsActive = true,
                        };

                        await Uow.GetRepository<Debit>().AddAsync(debit);
                        

                    }

                    var result = await Uow.SaveAsync();
                     
                    view.IsSucceed = true;
                    view.Statuses = "x-debit";

                }


                /*
                 
                        AccountId  --  ApartmentId  --  HousingId  -- Amount 
                */





                //var ls_housing_count = await Uow.GetRepository<Housing>().CountAsync(x => !x.IsDeleted && x.IsActive == true && x.ApartmentId == apartment_id);

                //if (ls_housing_count > 0)
                //{
                //    var ls_expense_calc = ls_expense.Sum(x => x.Amount);
                //    var calc = ls_expense_calc / ls_housing_count;

                //    var vw = new ExpenseDTO.Calc()
                //    {
                //        TotalAmount = ls_expense_calc.HasValue ? ls_expense_calc.Value.ToString("N", Culture) : "0",
                //        CalcAmount = calc.HasValue ? calc.Value.ToString("N2", Culture) : "0"
                //    };

                //    //view.View = vw;
                //    view.IsSucceed = true;
                //    view.Statuses = "x-calc";
                //}
                //else
                //{
                //    view.IsSucceed = true;
                //    view.Statuses = "x-housing";
                //}

            }
            else
            {
                view.IsSucceed = true;
                view.Statuses = "x-fail";
            }

            return view;
        }
    }
}
