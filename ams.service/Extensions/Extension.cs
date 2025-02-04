namespace ams.service.Extensions
{
    using ams.service.Services.Abstractions;
    using ams.service.Services.Concretes;
    using Microsoft.Extensions.DependencyInjection;

    public static class Extension
    {
        public static IServiceCollection ServiceHelper(this IServiceCollection services)
        {
            //var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IApartmentService, ApartmentService>();
            services.AddScoped<IExpenseService, ExpenseService>();
            services.AddScoped<IHousingService, HousingService>();
            services.AddScoped<IHousingSafeService, HousingSafeService>();
            services.AddScoped<IHousingSafeMovement, HousingSafeMovementService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IDebitService, DebitService>();
            services.AddScoped<IDashboardService, DashboardService>();
            
            return services;
        }
    }
}
