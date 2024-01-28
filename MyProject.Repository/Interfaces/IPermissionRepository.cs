using MyProject.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository.Interfaces
{
   public interface IPermissionRepository
    {
        List<Permission> getAll();
        Permission getById(int id);
        Permission Add(Permission permission);

        Permission Update(Permission permission);
        void Delete(int id);
    }
}
