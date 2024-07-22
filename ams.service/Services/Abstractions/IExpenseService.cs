﻿namespace ams.service.Services.Abstractions
{
    using ams.core.Units;
    using ams.entity.DTOs;

	public interface IExpenseService
	{
        Task<List<ExpenseDTO.ListView>> GetExpenses(Guid apartment_id, int month, int year);
        Task<ExpenseDTO.Detail> GetExpense(Guid expense_id);
        Task<Result.ViewResult> AddAsync(ExpenseDTO.Add dto);
        Task<Result.ViewResult> EditAsync(ExpenseDTO.Edit dto);
    }
}
