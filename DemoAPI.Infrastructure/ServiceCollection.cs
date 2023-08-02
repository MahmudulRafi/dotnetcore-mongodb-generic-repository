using DemoAPI.Domain.Interfaces;
using DemoAPI.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DemoAPI.Infrastructure
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddApplicationInfrastructure(this IServiceCollection services, IConfiguration configuation)
        {
            MongoDbContext mongoDbContext = new MongoDbContext(configuation.GetSection("MongoConnectionSetting")["ConnectionString"]);
            services.AddScoped<IUnitOfWork>(e => new UnitOfWork(mongoDbContext));
            return services;
        }
    }
}
