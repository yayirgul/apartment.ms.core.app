namespace ams.service.Services.Abstractions
{
    using ams.core.Units;
    using ams.entity.DTOs;

    public interface IHousingSafeService
    {
        Task<Result.ViewResult<HousingSafeDTO.Detail>> GetSafeHousingId(Guid housing_id);
        Task<Result.ListResult<HousingSafeDTO.Table>> GetHousingSafes();
    }
}
