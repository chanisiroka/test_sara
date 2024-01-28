using AutoMapper;
using MyProject.Common.Models;
using MyProject.Repository.Entities;
using MyProject.Repository.Interfaces;
using MyProject.Repository.Repositories;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
   public class RoleService : IService<RoleModel>
    {
        private readonly IRepository<Role> roleRepository;
        private readonly IMapper mapper;
        public RoleService(IRepository<Role> roleRepository,IMapper mapper)
        {
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }
        public async Task<RoleModel> AddAsync(RoleModel roleModel)
        {

           return  mapper.Map<RoleModel>(await roleRepository.AddAsync(roleModel.Id,roleModel.Name,roleModel.Description));
        }

        public async Task DeleteAsync(int id)
        {
           await roleRepository.DeleteAsync(id);
        }

        public async Task<List<RoleModel>> getAllAsync()
        {
            return mapper.Map<List<RoleModel>>(await roleRepository.getAllAsync());
        }

        public async Task<RoleModel> getByIdAsync(int id)
        {
            return mapper.Map<RoleModel>(await roleRepository.getByIdAsync(id));
        }

        public async Task<RoleModel> UpdateAsync(RoleModel roleModel)
        {
        var c= await roleRepository.UpdateAsync(mapper.Map<Role>(roleModel));
            return mapper.Map<RoleModel>( c);
        }
    }
}
