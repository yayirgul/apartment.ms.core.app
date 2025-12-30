namespace ams.service.Services.Abstractions
{
    using ams.entity.DTOs;
    public interface IYearService
    {
        Task<List<YearDTO.Combo>> GetComboYears();
    }
}