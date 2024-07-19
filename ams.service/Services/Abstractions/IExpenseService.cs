namespace ams.service.Services.Abstractions
{
	using ams.entity.DTOs;

	public interface IExpenseService
	{
		Task<List<ExpenseDTO.ListView>> GetExpenses(bool is_active, Guid apartment_id, int month, int year);
        Task AddAsync(ExpenseDTO.Add dto);
        Task<string> EditAsync(ExpenseDTO.Edit dto);
    }
}
