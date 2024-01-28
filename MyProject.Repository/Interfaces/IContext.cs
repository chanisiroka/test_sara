using Microsoft.EntityFrameworkCore;
using MyProject.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository.Interfaces
{
   public interface IContext
    {
        DbSet<Role> Roles { get; set; }
        DbSet<Claim> Claims { get; set; }
        DbSet<Permission> Permissions { get; set; }
        public Task  save();
    }
}
