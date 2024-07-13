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

        public async Task<List<ApartmentDTO.ListView>> GetAllAsync()
        {
            var r = await Uow.GetRepository<Apartment>().GetAllAsync(x => !x.IsDeleted, y => y.User!);
            

            var apartments = r.ConvertAll(x => new ApartmentDTO.ListView
            {
                ApartmentId = x.Id,
                ApartmentName = x.ApartmentName,
                CreateTime = x.CreateTime,
                _CreateTime = x.CreateTime != null ? x.CreateTime.ToString("dd/MM/yyyy") : "",
                CreateUser = x.User != null ? x.User!.Firstname + " " + x.User.Lastname : "",
                IsActive = x.IsActive ? 1 : 2,
            });

            return apartments;
            //return await Uow.GetRepository<Apartment>().GetAllAsync(x => !x.IsDeleted, y => y.User!);
        }
    }
}
