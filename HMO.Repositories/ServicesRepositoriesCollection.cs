using HMO.Repositories.Entities;
using HMO.Repositories.Interfaces;
using HMO.Repositories.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HMO.Repositories
{
    public static class ServicesRepositoriesCollection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection service)
        {
            service.AddScoped<IDataRepository<User>, UserRepository>();
            service.AddScoped<IDataRepository<Child>, ChildRepository>();
            return service;
        }

    }
}