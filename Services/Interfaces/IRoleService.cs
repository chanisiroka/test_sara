using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Common.Models;

namespace Services.Interfaces
{
  public  interface IRoleService
    {
       Task< List<RoleModel>> getAllAsync();
       Task< RoleModel> getByIdAsync(int id);
       Task< RoleModel> AddAsync(RoleModel roleModel);
       Task< RoleModel> UpdateAsync(RoleModel roleModel);
        Task DeleteAsync(int id);
    }
}
