namespace ams.service.Services.Concretes
{
    using ams.core.Units;
    using ams.data.UnitOfWorks;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;
    using System.Globalization;

    public class HousingSafeService : IHousingSafeService
    {
        private readonly IUnitOfWork Uow;
        private readonly CultureInfo Culture;

        public HousingSafeService(IUnitOfWork uow)
        {
            Uow = uow;
            Culture = new CultureInfo("tr-TR");
        }

        public async Task<Result.ViewResult<HousingSafeDTO.Detail>> GetSafeHousingId(Guid housing_id)
        {
            var view = new Result.ViewResult<HousingSafeDTO.Detail>();

            var detail = await Uow.GetRepository<HousingSafe>().GetAsync(x => !x.IsDeleted && x.HousingId == housing_id);

            if (detail == null)
            {
                view.View = new HousingSafeDTO.Detail() { Amount = 0, _Amount = "0,00" };
                view.IsSucceed = true;
                view.Statuses = "x-ndata";
            }
            else
            {
                if (detail != null)
                {
                    view.View = new HousingSafeDTO.Detail()
                    {
                        Id = detail!.Id,
                        Amount = detail!.Amount,
                        _Amount = detail.Amount.HasValue ? detail.Amount.Value.ToString("N2", Culture) : "0",
                    };
                    view.IsSucceed = true;
                    view.Statuses = "x-detail";
                }
                else
                {
                    view.View = new HousingSafeDTO.Detail() { _Amount = "0,00" };
                    view.IsSucceed = true;
                    view.Statuses = "x-fail";
                }
            }

            return view;
        }

        public async Task<Result.ListResult<HousingSafeDTO.Table>> GetHousingSafes(Guid apartment_id)
        {
            var result = new Result.ListResult<HousingSafeDTO.Table>();

            var ls = await Uow.GetRepository<HousingSafe>().GetAllAsync(
                a => !a.IsDeleted && a.IsActive == true && a.ApartmentId == apartment_id,
                b => b.Housing!,
                d => d.CreateTheUser!,
                e => e.ModifiedTheUser!,
                f => f.HousingSafeTheUser!
                );

            var housing_safe = ls.ConvertAll(x => new HousingSafeDTO.Table
            {
                Id = x.Id,
                //AccountId = x.AccountId,
                ApartmentId = x.ApartmentId,
                HousingName = x.Housing!.HousingName + " " + x.Housing.HousingNo,
                HousingNo = x.Housing!.HousingNo!,
                CreateTime = x.CreateTime,
                _CreateTime = x.CreateTime != null ? x.CreateTime.ToString("dd/MM/yyyy") : "-",
                _ModifiedTime = x.ModifiedTime != null ? x.ModifiedTime.Value.ToString("dd/MM/yyyy") : "-",
                IsActive = x.IsActive ? 1 : 2,
                CreateUser = x.CreateTheUser != null ? x.CreateTheUser.Firstname + " " + x.CreateTheUser.Lastname : "-",
                ModifiedUser = x.ModifiedTheUser != null ? x.ModifiedTheUser.Firstname + " " + x.ModifiedTheUser.Lastname : "-",
                HousingUser = x.HousingSafeTheUser != null ? x.HousingSafeTheUser.Firstname + " " + x.HousingSafeTheUser.Lastname : "-",
                _Amount = x.Amount.HasValue ? x.Amount.Value.ToString("N2", Culture) : "0",
            }).OrderBy(x => x.HousingNo).ToList();

            if (housing_safe.Count() > 0)
            {
                result.ListView = housing_safe;
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

        public async Task<Result.ViewResult> AmountEdit(HousingSafeDTO.Edit dto)
        {
            var housing_safe = await Uow.GetRepository<HousingSafe>().GetAsync(x => !x.IsDeleted && x.HousingId == dto.HousingId);

            decimal amount;
            decimal.TryParse(dto.Amount, NumberStyles.Number, Culture, out amount);

            housing_safe!.Amount = amount;
            housing_safe.ModifiedTime = dto.ModifiedTime;
            housing_safe.ModifiedUser = dto.ModifiedUser;
        
            await Uow.GetRepository<HousingSafe>().UpdateAsync(housing_safe);
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
    }
}
