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

        public async Task<Result.ListResult<DashboardDTO.Expense>> GetExpenseChart(Guid? account_id, Guid apartment_id, string type, int year)
        {
            var lrs = new Result.ListResult<DashboardDTO.Expense>();
            var list = new List<Expense>();

            var start = DateTime.Now.Date;
            start = new DateTime(year, 1, 1);

            if (type == "expense")
            {
                // TODO : Annual variable expenses
                var ls = await Uow.GetRepository<Expense>().GetAllAsync(x => !x.IsDeleted && x.AccountId == account_id && x.ApartmentId == apartment_id && x.IsFixed == false && x.Year == year);

                // TODO : Annual fixed expenses 
                var lsf = await Uow.GetRepository<Expense>().GetAllAsync(x => !x.IsDeleted && x.AccountId == account_id && x.ApartmentId == apartment_id && x.Year == year && x.IsFixed == true);

                //list = ls.Concat(lsf).ToList();

                var lr = new List<DashboardDTO.Expense>();

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
            }

            if (type == "debit")
            {
                var lr = new List<DashboardDTO.Expense>();

                var ls = await Uow.GetRepository<Debit>()
                    .GetAllAsync(x => !x.IsDeleted && x.AccountId == account_id && x.ApartmentId == apartment_id && !x.Paid && x._Year == year);

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
            }

            return lrs;
        }
    }
}
