namespace ams.service.Services.Abstractions
{
	using ams.entity.DTOs;

	public interface IApartmentService
    {
        Task<List<ApartmentDTO.ListView>> GetAllAsync();
    }
}
