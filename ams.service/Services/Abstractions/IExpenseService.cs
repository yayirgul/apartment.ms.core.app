namespace ams.service.Services.Abstractions
{
    using ams.core.Units;
    using ams.entity.DTOs;

	public interface IExpenseService
	{
        Task<List<ExpenseDTO.ListView>> GetExpenses(bool is_active, Guid apartment_id, int month, int year);
        Task<ExpenseDTO.Detail> GetExpense(Guid expense_id);
        Task AddAsync(ExpenseDTO.Add dto);
        Task<Result.ViewResult> EditAsync(ExpenseDTO.Edit dto);
    }
}
