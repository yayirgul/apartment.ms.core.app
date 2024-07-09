namespace ams.data.UnitOfWorks
{
    using ams.data.Context;
    using ams.data.Repositories.Abstractions;
    using ams.data.Repositories.Concretes;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext Context;

        public UnitOfWork(AppDbContext context)
        {
            Context = context;
        }

        public async ValueTask DisposeAsync()
        {
            await Context.DisposeAsync();
        }

        public int Save()
        {
            return Context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await Context.SaveChangesAsync();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new Repository<T>(Context);
        }
    }
}
