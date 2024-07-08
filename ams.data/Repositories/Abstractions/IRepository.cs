namespace ams.data.Repositories.Abstractions
{
    using ams.core.Entities;
    using System.Linq.Expressions;

    public interface IRepository<T> where T : class, IEntityBase, new()
    {
        Task AddAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> where);
        Task<int> CountAsync(Expression<Func<T, bool>> where);
        Task DeleteAsync(T entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? where, params Expression<Func<T, object>>[] inculude);
        Task<T?> GetAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] inculude);
        Task<T?> GetByIdAsync(Guid id);
        Task<T> UpdateAsync(T entity);
    }
}
