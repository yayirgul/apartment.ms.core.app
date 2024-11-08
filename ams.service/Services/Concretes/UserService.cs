namespace ams.service.Services.Concretes
{
    using ams.core.Units;
    using ams.data.UnitOfWorks;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class UserService : IUserService
    {
        private readonly IUnitOfWork Uow;
        private readonly UserManager<AppUser> UserManager;
        private readonly RoleManager<AppRole> RoleManager;

        public UserService(IUnitOfWork uow, UserManager<AppUser> UserManager, RoleManager<AppRole> RoleManager)
        {
            Uow = uow;
            this.UserManager = UserManager;
            this.RoleManager = RoleManager;
        }

        public async Task<Result.ViewResult> GetUserVerify(string user_id, string token)
        {
            var view = new Result.ViewResult();

            var user = await UserManager.FindByIdAsync(user_id);

            if (user != null)
            {
                var result = await UserManager.ConfirmEmailAsync(user, token);

                if (result.Succeeded)
                {
                    view.IsSucceed = true;
                    view.Statuses = "x-verify";
                }
            }

            return view;
        }

        public async Task<Result.ViewResult> AddAsync(UserDTO.Add dto)
        {
            var view = new Result.ViewResult();

            var email = await UserManager.FindByEmailAsync(dto.Email!);

            if (email == null)
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

                    var token = await UserManager.GenerateEmailConfirmationTokenAsync(user);

                    view.IsSucceed = true;
                    view.Statuses = "x-add";
                    view.Key = user.Id.ToString();
                    view.Token = token;

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
            var q_role = string.Join("", await UserManager.GetRolesAsync(q_user!));

            //var user = new AppUser()
            //{
            //    Id = dto.Id,
            //    PhoneNumber = dto.Phone
            //};

            q_user!.UserName = dto.Email;
            q_user.Firstname = dto.Firstname;
            q_user.Lastname = dto.Lastname;
            q_user.Email = dto.Email;
            q_user!.ModifiedUser = dto.ModifiedUser;
            q_user.ModifiedTime = dto.ModifiedTime;

            var result = await UserManager.UpdateAsync(q_user);

            if (result.Succeeded)
            {
                var role = await RoleManager.FindByIdAsync(dto.RoleId.ToString());

                await UserManager.RemoveFromRoleAsync(q_user!, q_role);
                await UserManager.AddToRoleAsync(q_user!, role!.Name!);

                view.IsSucceed = true;
                view.Statuses = "x-edit";
            }
            else
            {
                view.IsSucceed = true;
                view.Statuses = "x-fail";
            }

            return view;
        }

        public async Task<Result.ListResult<UserDTO.ComboBox>> GetComboHousingUser(Guid housing_id)
        {
            var result = new Result.ListResult<UserDTO.ComboBox>();
            var lv = new List<UserDTO.ComboBox>();

            var housing = await Uow.GetRepository<Housing>().GetAsync(x => !x.IsDeleted && x.IsActive == true && x.Id == housing_id);

            if (housing != null)
            {
                var user = await UserManager.Users.Where(x => x.IsActive == true && x.Id == housing.HousingUser).FirstOrDefaultAsync();

                if (user != null)
                {
                    lv.Add(new UserDTO.ComboBox()
                    {
                        Id = user.Id,
                        DisplayName = user.Firstname + " " + user.Lastname,
                    });
                }
            }
            
            result.ListView = lv;
            result.IsSucceed = true;
            result.Statuses = lv.Count() > 0 ? "x-list" : lv.Count() == 0 ? "x-list" : "x-fail";

            return result;
        }

        public async Task<Result.ListResult<UserDTO.ComboBox>> GetComboHousingUsers(Guid apartment_id)
        {
            var result = new Result.ListResult<UserDTO.ComboBox>();
            var lv = new List<UserDTO.ComboBox>();

            var l = await UserManager.Users.Where(x => x.IsActive == true).ToListAsync();
            var housing = await Uow.GetRepository<Housing>().GetAllAsync(x => !x.IsDeleted && x.IsActive == true && x.ApartmentId == apartment_id); // LIST

            foreach (var user in l)
            {
                var housing_user = housing.Where(x => x.HousingUser == user.Id).FirstOrDefault();

                if (housing_user == null)
                {
                    lv.Add(new UserDTO.ComboBox()
                    {
                        Id = user.Id,
                        DisplayName = user.Firstname + " " + user.Lastname,
                    });
                }

                // TODO : Combo'ya daha önce hiçbir konuta bağlanmamış kullanıcılar gelecek ve "EDIT" butonuna basınca o konuta bağlı kullanıcı gelecek şekilde ayarlanmalıdır.

                //if (housing_user != null) {
                //    if (housing_user!.HousingUser == user.Id)
                //    {
                //        lv.Add(new UserDTO.ComboList()
                //        {
                //            Id = user.Id,
                //            DisplayName = user.Firstname + " " + user.Lastname,
                //        });
                //    }
                //}
            }

            result.ListView = lv;
            result.IsSucceed = true;
            result.Statuses = lv.Count() > 0 ? "x-list" : lv.Count() == 0 ? "x-list" : "x-fail";

            return result;
        }

        public async Task<List<UserDTO.ComboBox>> GetComboUsers()
        {
            var l = await UserManager.Users.Where(x => x.IsActive == true).ToListAsync();

            var users = new List<UserDTO.ComboBox>();

            foreach (var user in l)
            {
                users.Add(new UserDTO.ComboBox()
                {
                    Id = user.Id,
                    DisplayName = user.Firstname + " " + user.Lastname,
                });
            }

            return users;
        }

        public async Task<Result.ViewResult<UserDTO.Detail>> GetUser(Guid user_id)
        {
            var view = new Result.ViewResult<UserDTO.Detail>();

            var user = await UserManager.FindByIdAsync(user_id.ToString());

            if (user != null)
            {
                var roles = await RoleManager.Roles.ToListAsync(); // Tüm "rollerin" listesi

                var role = string.Join("", await UserManager.GetRolesAsync(user));


                var role_id = roles.FirstOrDefault(x => x.Name == role)!.Id;


                //var rr = RoleManager.GetRoleNameAsync

                view.View = new UserDTO.Detail()
                {
                    Id = user.Id,
                    IsActive = user.IsActive,
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    Email = user.Email,
                    ModifiedTime = user.ModifiedTime,
                    RoleId = role_id,
                };
                view.IsSucceed = true;
                view.Statuses = "x-detail";
            }
            else
            {
                view.IsSucceed = false;
                view.Statuses = "x-fail";
            }

            return view;
        }

        public async Task<List<UserDTO.Table>> GetUsers()
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


            var users = new List<UserDTO.Table>();

            foreach (var user in l)
            {
                var fuser = await UserManager.FindByIdAsync(user.Id.ToString());

                users.Add(new UserDTO.Table()
                {
                    Id = user.Id,
                    AccountId = user.AccountId,
                    Role = string.Join("-", await UserManager.GetRolesAsync(fuser!)).ToUpper(),
                    Firstname = user.Firstname,
                    DisplayName = user.Firstname + " " + user.Lastname,
                    IsActive = user.IsActive ? 1 : 2,
                    _CreateTime = user.CreateTime != null ? user.CreateTime.ToString("dd/MM/yyyy") : "-",
                    _ModifiedTime = user.ModifiedTime != null ? user.ModifiedTime.Value.ToString("dd/MM/yyyy") : "-",
                    EmailConfirmed = user.EmailConfirmed ? 1 : 0
                });
            }

            return users;
        }
    }
}
