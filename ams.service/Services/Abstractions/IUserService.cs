using ams.entity.DTOs;

namespace ams.service.Services.Abstractions
{
    public interface IUserService
    {
        Task<List<UserDTO.ComboList>> GetComboUsers();
        Task<List<UserDTO.List>> GetUsers();
    }
}
