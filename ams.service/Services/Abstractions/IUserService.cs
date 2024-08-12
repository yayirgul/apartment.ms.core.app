using ams.core.Units;
using ams.entity.DTOs;

namespace ams.service.Services.Abstractions
{
    public interface IUserService
    {
        Task<Result.ViewResult> EditAsync(UserDTO.Edit dto);
        Task<Result.ViewResult> AddAsync(UserDTO.Add dto);
        Task<Result.ListResult<UserDTO.ComboList>> GetComboHousingUser(Guid apartment_id);
        Task<List<UserDTO.ComboList>> GetComboUsers();
        Task<List<UserDTO.List>> GetUsers();
    }
}
