using Microsoft.EntityFrameworkCore;
using MyProject.Repository.Entities;
using MyProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DbProyectContext
{
    public class ProyectDb : DbContext, IContext
    {
        public DbSet<Role> Roles { get ; set ; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Permission> Permissions { get ; set ; }

        public async Task save()
        {
            SaveChangesAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-6367N4E;database=newdb;trusted_connection=true");
        }
    }
}
