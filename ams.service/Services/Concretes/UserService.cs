namespace ams.service.Services.Concretes
{
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> UserManager;
        private readonly RoleManager<AppRole> RoleManager;

        public UserService(UserManager<AppUser> UserManager, RoleManager<AppRole> RoleManager)
        {
            this.UserManager = UserManager;
            this.RoleManager = RoleManager;
        }

        public async Task<List<UserDTO.ComboList>> GetComboUsers()
        {
            var l = await UserManager.Users.Where(x => x.IsActive == true).ToListAsync();
  
            var users = new List<UserDTO.ComboList>();

            foreach (var user in l)
            {
                users.Add(new UserDTO.ComboList()
                {
                    Id = user.Id,
                    DisplayName = user.Firstname +  " " + user.Lastname,
                });
            }

            return users;
        }

        public async Task<List<UserDTO.List>> GetUsers()
        {
            var l = await UserManager.Users.ToListAsync();

            //async Task<string> GetRole(Guid id)
            //{
            //    var u = await UserManager.FindByIdAsync(id.ToString());
            //    var role = string.Join("-", await UserManager.GetRolesAsync(u!));
            //    return role;
            //}

            //var users = l.ToList().ConvertAll(async x => new UserDTO.List
            //{
            //    Role = await GetRole(x.Id)
            //});


            var users = new List<UserDTO.List>();

            foreach (var user in l)
            {
                var fuser = await UserManager.FindByIdAsync(user.Id.ToString());

                users.Add(new UserDTO.List()
                {
                    Id = user.Id,
                    AccountId = user.AccountId,
                    Role = string.Join("-", await UserManager.GetRolesAsync(fuser!)).ToUpper(),
                    Firstname = user.Firstname,
                    DisplayName = user.Firstname + " " + user.Lastname,
                    IsActive = user.IsActive ? 1 : 2,
                    _CreateTime = user.CreateTime != null ? user.CreateTime.ToString("dd/MM/yyyy") : "-",
                    _ModifiedTime = user.ModifiedTime != null ? user.ModifiedTime.Value.ToString("dd/MM/yyyy") : "-",
                });
            }

            return users;
        }
    }
}
