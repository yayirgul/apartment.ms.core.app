namespace ams.service.Services.Abstractions
{
	using ams.entity.DTOs;

	public interface IApartmentService
    {
        Task<List<ApartmentDTO.ComboListView>> GetComboApartment(bool is_active);
        Task<List<ApartmentDTO.ListView>> GetAllAsync();
    }
}
