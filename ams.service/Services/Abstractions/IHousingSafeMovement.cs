using ams.core.Units;
using ams.entity.DTOs;

namespace ams.service.Services.Abstractions
{
    public interface IHousingSafeMovement
    {
        Task<Result.ListResult<HousingSafeMovementDTO.Table>> GetMovementHousingId(Guid housing_id, int month, int year);
    }
}
