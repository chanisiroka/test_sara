using Microsoft.Extensions.DependencyInjection;
using MyProject.Repository.Entities;
using MyProject.Repository.Interfaces;
using MyProject.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Role>,RoleRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IClaimRepository,ClaimRepository>();
            return services;
        }
    }
}
