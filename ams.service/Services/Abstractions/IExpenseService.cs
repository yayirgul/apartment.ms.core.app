namespace ams.service.Services.Abstractions
{
	using ams.entity.DTOs;

	public interface IExpenseService
	{
		Task<List<ExpenseDTO.ListView>> GetAllAsync(bool is_active);
	}
}
