namespace ams.service.Services.Concretes
{
    using ams.core.Units;
    using ams.data.UnitOfWorks;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;
    using System;
    using System.Globalization;
    using System.Threading.Tasks;

    public class DashboardService : IDashboardService
    {
        private readonly IUnitOfWork Uow;
        private readonly CultureInfo Culture;

        public DashboardService(IUnitOfWork uow)
        {
            Uow = uow;
            Culture = new CultureInfo("tr-TR");
        }

        public async Task<Result.ListResult<DashboardDTO.Expense>> GetExpenseChart(Guid? account_id, string apartment, string type, int year)
        {
            var lrs = new Result.ListResult<DashboardDTO.Expense>();
            var list = new List<Expense>();

            var start = DateTime.Now.Date;
            start = new DateTime(year, 1, 1);

            var lr = new List<DashboardDTO.Expense>();

            if (type == "expense")
            {
                // TODO : Annual variable expenses
                var ls = await Uow.GetRepository<Expense>()
                    .GetAllAsync(x => !x.IsDeleted && x.IsFixed == false &&
                    x.AccountId == account_id && 
                    x.ApartmentId == Guid.Parse(apartment) && 
                    x.Year == year);

                // TODO : Annual fixed expenses 
                var lsf = await Uow.GetRepository<Expense>()
                    .GetAllAsync(x => !x.IsDeleted && x.IsFixed == true &&
                    x.AccountId == account_id && 
                    x.ApartmentId == Guid.Parse(apartment) && 
                    x.Year == year);

                for (var i = 1; i <= 12; i++)
                {
                    var started = new DateTime(start.Year, i, 1);
                    var ended = started.AddMonths(1);

                    var l = new List<Expense>();
                    var lss = ls.Where(x => x.CreateTime >= started && x.CreateTime <= ended).ToList();

                    if (lss.Count > 0)
                        l = lss.Concat(lsf).ToList();

                    var amount = l.Sum(x => x.Amount);
                    //var amount = list.Where(x => x.CreateTime >= started && x.CreateTime < ended).Sum(x => x.Amount);

                    lr.Add(new DashboardDTO.Expense()
                    {
                        Amount = amount.HasValue ? amount.Value : 0,
                        _Amount = amount.HasValue ? amount.Value.ToString("N2", Culture) : "0"
                    });
                }
            }

            if (type == "debit")
            {
                var ls = await Uow.GetRepository<Debit>()
                    .GetAllAsync(x => !x.IsDeleted && !x.Paid &&
                    x.AccountId == account_id &&
                    x.ApartmentId == Guid.Parse(apartment) &&
                    x._Year == year);

                for (var i = 1; i <= 12; i++)
                {
                    var started = new DateTime(start.Year, i, 1);
                    var ended = started.AddMonths(1);
                    var amount = ls.Where(x => x.CreateTime >= started && x.CreateTime < ended).Sum(x => x.Amount);

                    lr.Add(new DashboardDTO.Expense()
                    {
                        Amount = amount.HasValue ? amount.Value : 0,
                        _Amount = amount.HasValue ? amount.Value.ToString("N2", Culture) : "0"
                    });
                }
            }

            if (lr.Count > 0)
            {
                lrs.ListView = lr;
                lrs.IsSucceed = true;
                lrs.Statuses = "x-list";
            }
            else
            {
                lrs.IsSucceed = true;
                lrs.Statuses = "x-fail";
            }

            return lrs;
        }

        public async Task<Result.ViewResult<DashboardDTO.Indicator>> GetIndicator(Guid? account_id, string apartment_id, int month, int year)
        {
            var result = new Result.ViewResult<DashboardDTO.Indicator>();

            #region TOTAL ANNUAL EXPENSES

            var lsr = new List<DashboardDTO.Expense>();

            var ls = await Uow.GetRepository<Expense>()
                .GetAllAsync(x => !x.IsDeleted && x.IsFixed == false &&
                x.AccountId == account_id &&
                x.ApartmentId == Guid.Parse(apartment_id) &&
                x.Year == year);

            var lsf = await Uow.GetRepository<Expense>()
                .GetAllAsync(x => !x.IsDeleted && x.IsFixed == true &&
                x.AccountId == account_id &&
                x.ApartmentId == Guid.Parse(apartment_id) &&
                x.Year == year);

            for (var i = 1; i <= 12; i++)
            { 
                var l = new List<Expense>();
                l = ls.Where(x => x.Month == i).Concat(lsf).ToList();

                var l_exp = l.Sum(x => x.Amount);

                lsr.Add(new DashboardDTO.Expense()
                {
                    Amount = l_exp.HasValue ? l_exp.Value : 0,
                    _Amount = l_exp.HasValue ? l_exp.Value.ToString("N2", Culture) : "0"
                });
            }

            var _expense = lsr.Sum(x => x.Amount);

            #endregion

            var debit = await Uow.GetRepository<Debit>()
                .GetAllAsync(x => !x.IsDeleted && !x.Paid && 
                x.AccountId == account_id && 
                x.ApartmentId == Guid.Parse(apartment_id) && 
                x._Month == month && 
                x._Year == year);

            var unpaid = debit.Sum(x => x.Amount);

            var housing_paid = await Uow.GetRepository<Housing>()
                .CountAsync(x => !x.IsDeleted && 
                x.AccountId == account_id && 
                x.ApartmentId == Guid.Parse(apartment_id));

            var housing_unpaid = await Uow.GetRepository<Debit>()
                .CountAsync(x => !x.IsDeleted && !x.Paid &&
                x.AccountId == account_id && 
                x.ApartmentId == Guid.Parse(apartment_id) && 
                x._Month == month && 
                x._Year == year);


            var view = new DashboardDTO.Indicator()
            {
                Unpaid = unpaid.HasValue ? unpaid.Value.ToString("N2", Culture) : "0",
                HousingPaid = housing_paid,
                HousingUnpaid = housing_unpaid,
                Expense = _expense.ToString("N2", Culture),
            };

            if (view != null)
            {
                result.View = view;
                result.IsSucceed = true;
                result.Statuses = "x-view";
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
