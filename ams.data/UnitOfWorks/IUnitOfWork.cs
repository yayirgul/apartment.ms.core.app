namespace ams.data.UnitOfWorks
{
    using ams.core.Entities;
    using ams.data.Repositories.Abstractions;

    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();
        Task<int> SaveAsync();
        int Save();
    }
}
