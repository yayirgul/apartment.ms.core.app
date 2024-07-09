namespace ams.data.Repositories.Concretes
{
    using ams.core.Entities;
    using ams.data.Context;
    using ams.data.Repositories.Abstractions;
    using Microsoft.EntityFrameworkCore;
    using System.Linq.Expressions;

    public class Repository<T> : IRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext Context;

        public Repository(AppDbContext context)
        {
            Context = context;
        }

        public DbSet<T> Table { get => Context.Set<T>(); }

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> where)
        {
            return await Table.AnyAsync(where);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> where)
        {
            if (where is not null)
                return await Table.CountAsync(where);

            return await Table.CountAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => { Table.Remove(entity); });
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? where = null, params Expression<Func<T, object>>[] inculude)
        {
            IQueryable<T> query = Table;

            if (where != null)
                query = query.Where(where);

            if (inculude.Any())
                foreach (var item in inculude)
                    query = query.Include(item);

            return await query.ToListAsync();
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] inculude)
        {
            IQueryable<T> query = Table;

            query = query.Where(where);

            if (inculude.Any())
                foreach (var item in inculude)
                    query = query.Include(item);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }
    }
}
