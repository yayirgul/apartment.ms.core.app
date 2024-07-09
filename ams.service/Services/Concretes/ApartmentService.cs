namespace ams.service.Services.Concretes
{
    using ams.data.UnitOfWorks;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;

    public class ApartmentService : IApartmentService
    {
        private readonly IUnitOfWork Uow;

        public ApartmentService(IUnitOfWork uow)
        {
            Uow = uow;
        }

        public async Task<List<Apartment>> GetAllAsync()
        {
            return await Uow.GetRepository<Apartment>().GetAllAsync();
        }
    }
}
