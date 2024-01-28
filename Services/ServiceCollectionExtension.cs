using Microsoft.Extensions.DependencyInjection;
using MyProject.Common.Models;
using MyProject.Repository;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services) 
    {
            services.AddRepositories();
            services.AddScoped<IService<RoleModel>, RoleService>();
            services.AddScoped<IClaimService, ClaimService>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddAutoMapper(typeof(MapperProfile));
            return services;
        }
    }
}
