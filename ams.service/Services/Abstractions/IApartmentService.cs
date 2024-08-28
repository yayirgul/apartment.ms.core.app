namespace ams.service.Services.Abstractions
{
    using ams.core.Units;
    using ams.entity.DTOs;

	public interface IApartmentService
    {
        Task<Result.ViewResult> AddAsync(ApartmentDTO.Add dto);
        Task<Result.ViewResult> EditAsync(ApartmentDTO.Edit dto);
        Task<List<ApartmentDTO.ComboListView>> GetComboApartment(bool is_active);
        Task<Result.ViewResult<ApartmentDTO.Detail>> GetApartment(Guid apartment_id);
        Task<List<ApartmentDTO.Table>> GetApartments();
    }
}
