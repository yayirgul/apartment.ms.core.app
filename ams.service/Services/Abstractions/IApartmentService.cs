namespace ams.service.Services.Abstractions
{
    using ams.entity.Entities;

    public interface IApartmentService
    {
        Task<List<Apartment>> GetAllAsync();
    }
}
