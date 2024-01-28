using Microsoft.EntityFrameworkCore;
using MyProject.Repository.Entities;
using MyProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository.Repositories
{
   public class RoleRepository : IRepository<Role>
    {
        private readonly IContext _context;
        public RoleRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Role> AddAsync(int id, string name, string desc)
        {
            Role newRole = new Role { Id = id, Name = name, Description = desc };
          await  _context.Roles.AddAsync(newRole);
           await _context.save();
            return newRole;
        }

        public async Task DeleteAsync(int id)
        {
            var role =await getByIdAsync(id);
            _context.Roles.Remove(role);
           await _context.save();

        }

        public async Task<List<Role>> getAllAsync()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<Role> getByIdAsync(int id)
        {
            return await _context.Roles.SingleAsync(x=>x.Id==id);
        }

        public async Task<Role> UpdateAsync(Role role)
        {
            //var updateRole = getByIdAsync(role.Id);
            //updateRole.Name = role.Name;
            //updateRole.Description = role.Description;
           var updateRole= _context.Roles.Update(role);
           await _context.save();
            return updateRole.Entity;
        }

       
    }
}
