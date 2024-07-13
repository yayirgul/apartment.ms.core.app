namespace ams.service.Services.Abstractions
{
    using ams.entity.DTOs;
    using ams.entity.Entities;

    public interface IApartmentService
    {
        Task<List<ApartmentDTO.ListView>> GetAllAsync();
    }
}
