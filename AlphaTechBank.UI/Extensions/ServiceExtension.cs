using AlphaTechBank.Core.ServiceManager.Abstraction;
using AlphaTechBank.Core.ServiceManager.Implementation;
using AlphaTechBank.Repository.Repository.UnitOfWork.Abstraction;
using AlphaTechBank.Repository.Repository.UnitOfWork.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace AlphaTechBank.UI.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureUnitOfWork(this IServiceCollection services) =>
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();
    }
}
