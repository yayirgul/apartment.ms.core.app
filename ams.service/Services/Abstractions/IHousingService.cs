namespace ams.service.Services.Abstractions
{
    using ams.core.Units;
    using ams.entity.DTOs;

    public interface IHousingService
    {
        Task<Result.ViewResult> AddAsync(HousingDTO.Add dto);
        Task<Result.ViewResult> EditAsync(HousingDTO.Edit dto);
        Task<Result.ViewResult<HousingDTO.Detail>> GetHousing(Guid housing_id);
        Task<List<HousingDTO.List>> GetHousings(Guid apartment_id);
    }
}
