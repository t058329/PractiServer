using HMO.Common.DTO_s;
using HMO.DBContext;
using HMO.Repositories;
using HMO.Services.Interfaces;
using HMO.Services.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Services
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IdataService<UserDto>, UserService>();
            services.AddScoped<IdataService<ChildDto>,ChilService>();
            services.AddSingleton<IContext, MyDbContext>();
            services.AddAutoMapper(typeof(MappingProfile));
            return services;

        }
    }
}
