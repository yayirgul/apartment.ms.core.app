namespace ams.service.Services.Abstractions
{
	using ams.core.Units;
	using ams.entity.DTOs;

	public interface IDashboardService
    {
        Task<Result.ListResult<DashboardDTO.Expense>> GetExpenseChart(Guid? account_id, Guid apartment_id, string type, int year);
        Task<Result.ViewResult<DashboardDTO.Indicator>> GetIndicator(Guid? account_id, string apartment_id, int month, int year);
    }
}
