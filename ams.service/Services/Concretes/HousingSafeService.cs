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
                view.IsSucceed = false;
                view.Statuses = "x-fail";
            }

            return view;
        }
 
        public async Task<Result.ListResult<HousingSafeDTO.Table>> GetHousingSafes()
        {
            var list = new Result.ListResult<HousingSafeDTO.Table>();

            var ls = await Uow.GetRepository<HousingSafe>().GetAllAsync(x => !x.IsDeleted, y => y.HousingSafeMovements!);


            return list;
        }
    }
}
