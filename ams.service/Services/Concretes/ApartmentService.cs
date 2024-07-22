namespace ams.service.Services.Concretes
{
    using ams.data.UnitOfWorks;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;

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

        public async Task<List<ApartmentDTO.ListView>> GetAllAsync()
        {
            var r = await Uow.GetRepository<Apartment>().GetAllAsync(x => !x.IsDeleted, y => y.CreateTheUser!);
            

            var apartments = r.ConvertAll(x => new ApartmentDTO.ListView
            {
                ApartmentId = x.Id,
                ApartmentName = x.ApartmentName,
                CreateTime = x.CreateTime,
                _CreateTime = x.CreateTime != null ? x.CreateTime.ToString("dd/MM/yyyy") : "",
                CreateUser = x.CreateTheUser != null ? x.CreateTheUser!.Firstname + " " + x.CreateTheUser.Lastname : "",
                IsActive = x.IsActive ? 1 : 2,
            });

            return apartments;
            //return await Uow.GetRepository<Apartment>().GetAllAsync(x => !x.IsDeleted, y => y.User!);
        }
    }
}
