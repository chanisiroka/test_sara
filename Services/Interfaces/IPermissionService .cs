using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Common.Models;

namespace Services.Interfaces
{
    public interface IPermissionService
    {
        List<PermissionModel> getAll();
        PermissionModel getById(int id);
        PermissionModel Add(PermissionModel permissionModel);
        PermissionModel Update(PermissionModel permissionModel);
        void Delete(int id);
    }
}
