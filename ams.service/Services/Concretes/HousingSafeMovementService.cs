namespace ams.service.Services.Concretes
{
    using ams.core.Units;
    using ams.data.UnitOfWorks;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;
    using System.Globalization;

    public class HousingSafeMovementService : IHousingSafeMovement
    {
        private readonly IUnitOfWork Uow;
        private readonly CultureInfo Culture;

        public HousingSafeMovementService(IUnitOfWork uow)
        {
            Uow = uow;
            Culture = new CultureInfo("tr-TR");
        }

        public async Task<Result.ListResult<HousingSafeMovementDTO.Table>> GetMovementHousingId(Guid housing_id, int month, int year)
        {
            var l = new Result.ListResult<HousingSafeMovementDTO.Table>();

            var ls = await Uow.GetRepository<HousingSafeMovement>().GetAllAsync(
                a => !a.IsDeleted && a.HousingId == housing_id && a._Month == month && a._Year == year, 
                b => b.HousingSafe!,
                c => c.Housing!,
                e => e.CreateTheUser!,
                f => f.ModifiedTheUser!
                );

            var movement = ls.ConvertAll(x => new HousingSafeMovementDTO.Table
            {
                HousingSafeAmount = x.HousingSafe!.Amount.HasValue ? x.HousingSafe.Amount.Value.ToString("N2", Culture) : "0",
                MovementAmount = x.MovementAmount.HasValue ? x.MovementAmount.Value.ToString("N2", Culture) : "0",
                DebitAmount = x.DebitAmount.HasValue ? x.DebitAmount.Value.ToString("N2", Culture) : "0",
                FormerAmount = x.FormerAmount.HasValue ? x.FormerAmount.Value.ToString("N2", Culture) : "0",
                _Month = month,
                _Year = year,
                MonthYear = month + "/" + year,
                CreateTime = x.CreateTime,
                _CreateTime = x.CreateTime != null ? x.CreateTime.ToString("dd/MM/yyyy") : "",
                CreateUser = x.CreateTheUser != null ? x.CreateTheUser.Firstname + " " + x.CreateTheUser.Lastname : "-",
                ModifiedUser = x.ModifiedTheUser != null ? x.ModifiedTheUser.Firstname + " " + x.ModifiedTheUser.Lastname : "-",
            });

            if (movement.Count() > 0)
            {
                l.ListView = movement;
                l.IsSucceed = true;
                l.Statuses = "x-list";
            }
            else
            {
                l.IsSucceed = true;
                l.Statuses = "x-fail";
            }

            return l;
        }
    }
}
