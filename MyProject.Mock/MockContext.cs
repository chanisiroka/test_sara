using Microsoft.EntityFrameworkCore;
using MyProject.Repository.Entities;
using MyProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Mock
{
   public class MockContext : IContext
    {
        public DbSet<Role> Roles { get; set ; }
        public DbSet<Claim> Claims { get ; set ; }
        public DbSet<Permission> Permissions { get ; set ; }
        public MockContext()
        {
           // this.Roles = new DbSet<Role>();
            //this.Permissions = new DbSet<Permission>();
           // this.Claims = new DbSet<Claim>();

            this.Roles.Add(new Role { Id = 1, Name = "admin", Description = "administrator with full access" });
            this.Roles.Add(new Role { Id = 2, Name = "user", Description = "user with limited access" });

            this.Permissions.Add(new Permission { Id = 1, Name = "VIEW_ALL_ORDERS" });
            this.Permissions.Add(new Permission { Id = 2, Name = "VIEW_ALL_PRODUCTS" });

            this.Claims.Add(new Claim { Id = 1, RoleId = 1, PermissionId = 1, Policy = ePolicy.Allow });
            this.Claims.Add(new Claim { Id = 2, RoleId = 2, PermissionId = 1, Policy = ePolicy.Deny });
            this.Claims.Add(new Claim { Id = 3, RoleId = 1, PermissionId = 2, Policy = ePolicy.Allow });
            this.Claims.Add(new Claim { Id = 4, RoleId = 2, PermissionId = 2, Policy = ePolicy.Allow });
        }

        

       public Task save()
        {
            throw new NotImplementedException();
        }
    }
}
