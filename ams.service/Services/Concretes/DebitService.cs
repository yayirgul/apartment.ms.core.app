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
            var view = new Result.ViewResult();

            var q_debit = await Uow.GetRepository<Debit>().GetAsync(x => !x.IsDeleted && x.IsActive == true && x._Month == month && x._Year == year);

            if (q_debit == null)
            {
                var ls_expense = await Uow.GetRepository<Expense>().GetAllAsync(x => !x.IsDeleted && x.IsActive == true && x.ApartmentId == apartment_id && x.Month == month && x.Year == year);

                if (ls_expense.Count() > 0)
                {
                    // Toplam 10 adet konut gelecek
                    var ls_housing = await Uow.GetRepository<Housing>().GetAllAsync(x => !x.IsDeleted && x.IsActive == true && x.ApartmentId == apartment_id);

                    if (ls_housing.Count() > 0)
                    {
                        var ls_expense_calc = ls_expense.Sum(x => x.Amount);
                        var amount = ls_expense_calc / ls_housing.Count();

                        foreach (var item in ls_housing.OrderBy(x => x.CreateTime))
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
                                ExpenseCode = "H:" + item.HousingNo + "-" + month + "/" + year,
                                Paid = false,
                                IsActive = true,
                                Queue = item.HousingNo
                            };
                            await Uow.GetRepository<Debit>().AddAsync(debit);
                        }

                        var result = await Uow.SaveAsync();

                        view.IsSucceed = true;
                        view.Statuses = "x-debit";

                    }

                }
                else
                {
                    view.IsSucceed = true;
                    view.Statuses = "x-fail";
                }
            }
            else
            {
                view.IsSucceed = true;
                view.Statuses = "x-duplicate";
            }

            return view;
        }

        public async Task<Result.ListResult<DebitDTO.Table>> GetDebits(Guid apartment_id, int month, int year)
        {
            var result = new Result.ListResult<DebitDTO.Table>();
            //var l = await Uow.GetRepository<Expense>().GetAllAsync(x => !x.IsDeleted && x.ApartmentId == apartment_id && x.Month == month && x.Year == year, y => y.CreateTheUser!, z => z.ModifiedTheUser!);


            var l = await Uow.GetRepository<Debit>().GetAllAsync(
                a => !a.IsDeleted && a.IsActive == true && a.ApartmentId == apartment_id && a._Month == month && a._Year == year, 
                b => b.Housing!,
                c => c.DebitTheUser!,
                d => d.CreateTheUser!,
                e => e.ModifiedTheUser!
                );

            var debits = l.ConvertAll(x => new DebitDTO.Table
            {
                Id = x.Id,
                HousingName = x.Housing!.HousingName + " " + x.Queue + " - [ <b class='text-dark'>" + x.DebitTheUser!.Firstname + " " + x.DebitTheUser.Lastname + "</b> ]",
                HousingUser = x.DebitTheUser != null ? x.DebitTheUser!.Firstname + " " + x.DebitTheUser.Lastname : "-",
                Amount = x.Amount,
                _Amount = x.Amount.HasValue ? x.Amount.Value.ToString("N2", Culture) : "0",
                CreateTime = x.CreateTime,
                _CreateTime = x.CreateTime != null ? x.CreateTime.ToString("dd/MM/yyyy") : "",
                ExpenseCode = x.ExpenseCode,
                _Month = x._Month,
                _Year = x._Year,
                IsActive = x.IsActive ? 1 : 2,
                Paid = x.Paid ? 1 : 2,
                CreateUser = x.CreateTheUser != null ? x.CreateTheUser.Firstname + " " + x.CreateTheUser.Lastname : "-",
                ModifiedUser = x.ModifiedTheUser != null ? x.ModifiedTheUser.Firstname + " " + x.ModifiedTheUser.Lastname : "-",
                Queue = x.Queue,
            }).OrderBy(x => x.Queue).ToList();


            if (debits.Count() > 0)
            {
                result.ListView = debits;
                result.IsSucceed = true;
                result.Statuses = "x-list";
            }
            else
            {
                result.IsSucceed = true;
                result.Statuses = "x-fail";
            }

            return result;
        }
    }
}
