namespace ams.service.Extensions
{
    using ams.service.Services.Abstractions;
    using ams.service.Services.Concretes;
    using Microsoft.Extensions.DependencyInjection;
    using System.Reflection;

    public static class Extension
    {
        public static IServiceCollection ServiceHelper(this IServiceCollection services)
        {
            //var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IApartmentService, ApartmentService>();
            services.AddScoped<IExpenseService, ExpenseService>();
            services.AddScoped<IHousingService, HousingService>();
            services.AddScoped<IUserService, UserService>();


            return services;
        }
    }
}
