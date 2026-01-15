namespace ams.service.Services.Concretes
{
    using ams.core.Units;
    using ams.data.Context;
    using ams.data.UnitOfWorks;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;
    using System;

    public class ApartmentService : IApartmentService
    {
        private readonly IUnitOfWork Uow;

        public ApartmentService(IUnitOfWork uow)
        {
            Uow = uow;
        }

        public async Task<List<ApartmentDTO.ComboListView>> GetComboApartment(bool is_active)
        {
            var list = await Uow.GetRepository<Apartment>().GetAllAsync(x => !x.IsDeleted && !x.IsDeleted && x.IsActive == is_active);

            var apartments = list.ConvertAll(x => new ApartmentDTO.ComboListView
            {
                Id = x.Id,
                ApartmentName = x.ApartmentName,
            });

            return apartments;
        }

        public async Task<Result.ViewResult> AddAsync(ApartmentDTO.Add dto)
        {
            var apartment = new Apartment()
            {
                AccountId = dto.AccountId,
                ApartmentName = dto.ApartmentName,
                CreateUser = dto.CreateUser,
                IsDeleted = false,
                IsActive = true,
            };

            await Uow.GetRepository<Apartment>().AddAsync(apartment);
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

        public async Task<Result.ViewResult> EditAsync(ApartmentDTO.Edit dto)
        {
            var apartment = await Uow.GetRepository<Apartment>().GetAsync(x => !x.IsDeleted && x.Id == dto.ApartmentId);

            apartment!.ApartmentName = dto.ApartmentName;
            apartment.ModifiedUser = dto.ModifiedUser;
            apartment.ModifiedTime = dto.ModifiedTime;
            
            await Uow.GetRepository<Apartment>().UpdateAsync(apartment);
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

        public async Task<Result.ViewResult<ApartmentDTO.Detail>> GetApartment(Guid apartment_id)
        {
            var view = new Result.ViewResult<ApartmentDTO.Detail>();

            var detail = await Uow.GetRepository<Apartment>().GetAsync(x => !x.IsDeleted && x.Id == apartment_id);

            if (detail != null)
            {
                view.View = new ApartmentDTO.Detail()
                {
                    Id = detail!.Id,
                    ApartmentName = detail!.ApartmentName,
                    _CreateTime = detail!.CreateTime.ToString("dd/MM/yyyy"),
                    _ModifiedTime = detail!.ModifiedTime.HasValue ? detail!.ModifiedTime.Value.ToString("dd/MM/yyyy") : "",
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

        public async Task<List<ApartmentDTO.Table>> GetApartments()
        {
            var r = await Uow.GetRepository<Apartment>().GetAllAsync(x => !x.IsDeleted, a => a.CreateTheUser!);

            var param = new Dictionary<string, object>{
                { "@ApartmentId", "16f885ff-6897-4d08-afa6-0640c40d2a05" },
                { "@AccountId", "16f885ff-6897-4d08-afa6-0640c40d2a05" }
            };

            //var sp = await Uow.GetRepository<Apartment>().GetAllExecuteAsync("sp_aparment_by_id", param);


            var apartments = r.ConvertAll(x => new ApartmentDTO.Table
            {
                ApartmentId = x.Id,
                ApartmentName = x.ApartmentName,
                CreateTime = x.CreateTime,
                _CreateTime = x.CreateTime != null ? x.CreateTime.ToString("dd/MM/yyyy") : "",
                CreateUser = x.CreateTheUser != null ? x.CreateTheUser!.Firstname + " " + x.CreateTheUser.Lastname : "",
                IsActive = x.IsActive ? 1 : 2,
                //TEST = AppDbContext.GetApartmentManager(x.Id)
            });

            return apartments;
        }
    }
}
