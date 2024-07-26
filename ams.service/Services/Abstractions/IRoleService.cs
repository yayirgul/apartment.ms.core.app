

namespace ams.service.Services.Abstractions
{
    using ams.core.Units;
    using ams.entity.DTOs;

    public interface IRoleService
    {
        Task<Result.ListResult<RoleDTO.Combo>> GetComboRoles();
    }
}
