namespace ams.service.Services.Concretes
{
    using ams.core.Units;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class RoleService : IRoleService
    {
        private readonly UserManager<AppUser> UserManager;
        private readonly RoleManager<AppRole> RoleManager;

        public RoleService(UserManager<AppUser> UserManager, RoleManager<AppRole> RoleManager)
        {
            this.UserManager = UserManager;
            this.RoleManager = RoleManager;
        }

        public async Task<Result.ListResult<RoleDTO.Combo>> GetComboRoles()
        {
            var result = new Result.ListResult<RoleDTO.Combo>();

            var l = await RoleManager.Roles.ToListAsync();

            var roles = l.ConvertAll(x => new RoleDTO.Combo
            {
                Id = x.Id,
                DisplayName = x.Name!.ToUpper()
            }).ToList();

            if (roles.Count() > 0)
            {
                result.ListView = roles;
                result.IsSucceed = true;
                result.Statuses = "x-combo";
            }
            else
            {
                result.IsSucceed = true;
                result.Statuses = "x-fail";
            }

            return result;
        }
    }
}
