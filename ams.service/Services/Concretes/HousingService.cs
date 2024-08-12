namespace ams.service.Services.Concretes
{
    using ams.core.Units;
    using ams.data.UnitOfWorks;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;
    using System.Globalization;

    public class HousingService : IHousingService
    {
        private readonly IUnitOfWork Uow;
        private readonly CultureInfo Culture;

        public HousingService(IUnitOfWork uow)
        {
            Uow = uow;
            Culture = new CultureInfo("tr-TR");
        }

        public async Task<Result.ViewResult> AddAsync(HousingDTO.Add dto)
        {
            var quid = new
            {
                HousingId = Guid.NewGuid(),
                HousingSafe = Guid.NewGuid(),
            };

            var housing = new Housing()
            {
                Id = quid.HousingId,
                AccountId = dto.AccountId,
                ApartmentId = dto.ApartmentId,
                HousingName = dto.HousingName,
                HousingNo = dto.HousingNo,
                CreateUser = dto.CreateUser,
                IsDeleted = false,
                IsActive = true,
                HousingUser = dto.HousingUser,
                HousingSafe = quid.HousingSafe,
            };

            var safe = new HousingSafe()
            {
                Id = quid.HousingSafe,
                AccountId = dto.AccountId,
                ApartmentId = (Guid)dto.ApartmentId!,
                HousingId = quid.HousingId,
                HousingSafeUser = dto.HousingUser,
                CreateUser = dto.CreateUser,
                IsDeleted = false,
                IsActive = true,
                Amount = 0
            };

            await Uow.GetRepository<Housing>().AddAsync(housing);
            await Uow.GetRepository<HousingSafe>().AddAsync(safe);
            var result = await Uow.SaveAsync();

            var view = new Result.ViewResult();

            if (result > 0)
            {
                view.IsSucceed = true;
                view.Statuses = "x-add";
            }
            else
            {
                view.IsSucceed = true;
                view.Statuses = "x-fail";
            }

            return view;
        }

        public async Task<Result.ViewResult> EditAsync(HousingDTO.Edit dto)
        {
            var housing = await Uow.GetRepository<Housing>().GetAsync(x => !x.IsDeleted && x.Id == dto.Id);

            housing!.HousingName = dto.HousingName;
            housing.HousingNo = dto.HousingNo;
            housing.ModifiedTime = dto.ModifiedTime;
            housing.ModifiedUser = dto.ModifiedUser;
            housing.HousingUser = dto.HousingUser;

            await Uow.GetRepository<Housing>().UpdateAsync(housing);
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

        public async Task<Result.ViewResult<HousingDTO.Detail>> GetHousing(Guid housing_id)
        {
            var view = new Result.ViewResult<HousingDTO.Detail>();

            var detail = await Uow.GetRepository<Housing>().GetAsync(x => !x.IsDeleted && x.Id == housing_id);

            //decimal amount; 
            //decimal.TryParse(view!.Amount.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out amount);

            if (detail != null)
            {
                //_Amount = view.Amount.HasValue ? view.Amount!.Value.ToString("#,##0.00") : ""
                //_Amount = view.Amount.HasValue ? amount.ToString("N2", Culture) : "",
                //_Amount = view.Amount.HasValue ? view.Amount.Value.ToString("N2", Culture) : "",

                view.View = new HousingDTO.Detail()
                {
                    Id = detail!.Id,
                    ApartmentId = detail.ApartmentId,
                    HousingName = detail!.HousingName,
                    HousingNo = detail!.HousingNo,
                    HousingUser = detail!.HousingUser,
                };
                view.IsSucceed = true;
                view.Statuses = "x-detail";
            }
            else
            {
                view.IsSucceed = false;
                view.Statuses = "x-fail";
            }

            return view;
        }

        public async Task<List<HousingDTO.List>> GetHousings(Guid apartment_id)
        {
            var l = await Uow.GetRepository<Housing>().GetAllAsync(x => !x.IsDeleted && x.ApartmentId == apartment_id, y => y.CreateTheUser!, z => z.ModifiedTheUser!, hs => hs.HousingTheSafe!, hu => hu.HousingTheUser!);

            var housing = l.ConvertAll(x => new HousingDTO.List
            {
                Id = x.Id,
                AccountId = x.AccountId,
                ApartmentId = x.ApartmentId,
                HousingName = x.HousingName + " " + x.HousingNo,
                HousingNo = x.HousingNo,
                //_Amount = x.Amount.HasValue ? x.Amount.Value.ToString("N2", Culture) : "0",
                CreateTime = x.CreateTime,
                _CreateTime = x.CreateTime != null ? x.CreateTime.ToString("dd/MM/yyyy") : "-",
                _ModifiedTime = x.ModifiedTime != null ? x.ModifiedTime.Value.ToString("dd/MM/yyyy") : "-",
                IsActive = x.IsActive ? 1 : 2,
                CreateUser = x.CreateTheUser != null ? x.CreateTheUser.Firstname + " " + x.CreateTheUser.Lastname : "-",
                ModifiedUser = x.ModifiedTheUser != null ? x.ModifiedTheUser.Firstname + " " + x.ModifiedTheUser.Lastname : "-",
                HousingUser = x.HousingTheUser != null ? x.HousingTheUser.Firstname + " " + x.HousingTheUser.Lastname : "-",
                _Amount = x.HousingTheSafe != null ? x.HousingTheSafe.Amount!.Value.ToString("N2", Culture) : "0"
            }).OrderBy(x => x.HousingNo).ToList();

            return housing;
        }
    }
}
