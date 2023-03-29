using DataLayer.Repositories;
using Core.Services;

namespace CRUD_API.Settings
{
    public static class Dependencies
    {

        public static void Inject(WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddControllers();
            applicationBuilder.Services.AddSwaggerGen();

            AddRepositories(applicationBuilder.Services);
            AddServices(applicationBuilder.Services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<ServiceService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<ProvidersRepository>();
            services.AddScoped<ServicesRepository>();
        }

    }
}
