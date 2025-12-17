namespace ams.service.Services.Abstractions
{
	using ams.core.Units;
	using ams.entity.DTOs;

	public interface IDashboardService
    {
		Task<Result.ListResult<DashboardDTO.Expense>> GetExpenseChart(Guid? account_id, Guid apartment_id, string type, int year);
	}
}
