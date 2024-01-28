using MyProject.Repository.Entities;
using MyProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository.Repositories
{
    class PermissionRepository : IPermissionRepository
    {
        private readonly IContext _context;
        public PermissionRepository(IContext context)
        {
            _context = context;
        }
        public Permission Add(Permission permission)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Permission> getAll()
        {
            throw new NotImplementedException();
        }

        public Permission getById(int id)
        {
            throw new NotImplementedException();
        }

        public Permission Update(Permission permission)
        {
            throw new NotImplementedException();
        }
    }
}
