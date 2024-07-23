using ams.entity.DTOs;

namespace ams.service.Services.Abstractions
{
    public interface IUserService
    {
        Task<List<UserDTO.List>> GetUsers();
    }
}
