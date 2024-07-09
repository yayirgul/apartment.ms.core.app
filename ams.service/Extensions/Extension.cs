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


            return services;
        }
    }
}
