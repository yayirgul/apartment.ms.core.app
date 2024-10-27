namespace ams.service.Services.Concretes
{
    using ams.data.UnitOfWorks;
    using ams.service.Services.Abstractions;

    public class DashboardService : IDashboardService
    {
        private readonly IUnitOfWork Uow;

        public DashboardService(IUnitOfWork uow)
        {
            Uow = uow;
        }
    }
}
