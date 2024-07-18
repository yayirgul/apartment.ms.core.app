namespace ams.service.Services.Abstractions
{
	using ams.entity.DTOs;

	public interface IExpenseService
	{
		Task<List<ExpenseDTO.ListView>> GetExpenses(bool is_active);
        Task AddAsync(ExpenseDTO.Add dto);
        Task<string> EditAsync(ExpenseDTO.Edit dto);
    }
}
