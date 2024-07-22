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
            var housing = new Housing()
            {
                AccountId = dto.AccountId,
                ApartmentId = dto.ApartmentId,
                HousingName = dto.HousingName,
                CreateUser = dto.CreateUser,
                IsDeleted = false,
                IsActive = true,
                HousingUser = dto.HousingUser,
            };

            await Uow.GetRepository<Housing>().AddAsync(housing);
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

        public async Task<Result.ViewResult> EditAsync(HousingDTO.Edit dto)
        {
            var housing = await Uow.GetRepository<Housing>().GetAsync(x => !x.IsDeleted && x.Id == dto.Id);

            housing!.HousingName = dto.HousingName;
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

        public async Task<List<HousingDTO.List>> GetHousings(Guid apartment_id)
        {
            var l = await Uow.GetRepository<Housing>().GetAllAsync(x => !x.IsDeleted && x.ApartmentId == apartment_id, y => y.CreateTheUser!, z => z.ModifiedTheUser!, hs => hs.HousingTheSafe!, hu => hu.HousingTheUser!);

            var housing = l.ConvertAll(x => new HousingDTO.List
            {
                Id = x.Id,
                AccountId = x.AccountId,
                ApartmentId = x.ApartmentId,
                HousingName = x.HousingName,
                //_Amount = x.Amount.HasValue ? x.Amount.Value.ToString("N2", Culture) : "0",
                _CreateTime = x.CreateTime != null ? x.CreateTime.ToString("dd/MM/yyyy") : "-",
                IsActive = x.IsActive ? 1 : 2,
                CreateUser = x.CreateTheUser != null ? x.CreateTheUser.Firstname + " " + x.CreateTheUser.Lastname : "-",
                ModifiedUser = x.ModifiedTheUser != null ? x.ModifiedTheUser.Firstname + " " + x.ModifiedTheUser.Lastname : "-",


                HousingUser = x.HousingTheUser != null ? x.HousingTheUser.Firstname + " " + x.HousingTheUser.Lastname : "-",


                _Amount = x.HousingTheSafe != null ? x.HousingTheSafe.Amount!.Value.ToString("N2", Culture) : "0"
            }).ToList();

            return housing;
        }
    }
}
