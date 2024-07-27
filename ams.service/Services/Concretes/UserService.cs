namespace ams.service.Services.Concretes
{
    using ams.core.Units;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
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

        public async Task<Result.ViewResult> AddAsync(UserDTO.Add dto)
        {
            var view = new Result.ViewResult();

            var email = await UserManager.FindByEmailAsync(dto.Email!);

            if (email == null) // BOŞ İSE
            {
                var user = new AppUser()
                {
                    AccountId = dto.AccountId,
                    UserName = dto.Email,
                    Firstname = dto.Firstname,
                    Lastname = dto.Lastname,
                    Email = dto.Email,
                    CreateUser = dto.CreateUser,
                    IsActive = true,
                    PhoneNumber = dto.Phone
                };

                var result = await UserManager.CreateAsync(user, string.IsNullOrEmpty(dto.Password) ? "" : dto.Password);

                if (result.Succeeded)
                {

                    var role = await RoleManager.FindByIdAsync(dto.RoleId.ToString());
                    await UserManager.AddToRoleAsync(user, role!.ToString());

                    view.IsSucceed = true;
                    view.Statuses = "x-add";

                }
                else
                {
                    view.IsSucceed = true;
                    view.Statuses = "x-fail";
                }
            }
            else
            {
                view.IsSucceed = true;
                view.Statuses = "x-duplicate";
            }

            return view;
        }

        public async Task<Result.ViewResult> EditAsync(UserDTO.Edit dto)
        {
            var view = new Result.ViewResult();

            var q_user = await UserManager.FindByIdAsync(dto.Id.ToString());
            var q_role = string.Join("", UserManager.GetRolesAsync(q_user!));

            var user = new AppUser()
            {
                UserName = dto.Email,
                Firstname = dto.Firstname,
                Lastname = dto.Lastname,
                Email = dto.Email,
                ModifiedUser = dto.ModifiedUser,
                PhoneNumber = dto.Phone
            };

            var result = await UserManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                var role = await RoleManager.FindByIdAsync(dto.RoleId.ToString());

                await UserManager.RemoveFromRoleAsync(user!, q_role);
                await UserManager.AddToRoleAsync(user!, role!.Name!);

                view.IsSucceed = true;
                view.Statuses = "x-add";
            }
            else
            {
                view.IsSucceed = true;
                view.Statuses = "x-fail";
            }

            return view;
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
                    DisplayName = user.Firstname + " " + user.Lastname,
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
