﻿using ams.core.Units;
using ams.entity.DTOs;

namespace ams.service.Services.Abstractions
{
    public interface IUserService
    {
        Task<Result.ViewResult> GetUserVerify(string user_id, string token);
        Task<Result.ViewResult> EditAsync(UserDTO.Edit dto);
        Task<Result.ViewResult> AddAsync(UserDTO.Add dto);
        Task<Result.ListResult<UserDTO.ComboBox>> GetComboHousingUser(Guid housing_id);
        Task<Result.ListResult<UserDTO.ComboBox>> GetComboHousingUsers(Guid apartment_id);
        Task<List<UserDTO.ComboBox>> GetComboUsers();
        Task<Result.ViewResult<UserDTO.Detail>> GetUser(Guid user_id);
        Task<List<UserDTO.Table>> GetUsers();
    }
}
