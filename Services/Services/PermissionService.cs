using AutoMapper;
using MyProject.Common.Models;
using MyProject.Repository.Entities;
using MyProject.Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository PermissionRepository;
        private readonly IMapper mapper;
        public PermissionService(IPermissionRepository PermissionRepository,IMapper mapper)
        {
            this.PermissionRepository = PermissionRepository;
            this.mapper = mapper;
        }
        public PermissionModel Add(PermissionModel PermissionModel)
        {
           return mapper.Map<PermissionModel>( PermissionRepository.Add(mapper.Map<Permission>(PermissionModel)));
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PermissionModel> getAll()
        {
            return mapper.Map<List<PermissionModel>>(PermissionRepository.getAll());
        }

        public PermissionModel getById(int id)
        {
            throw new NotImplementedException();
        }

        public PermissionModel Update(PermissionModel PermissionModel)
        {
            throw new NotImplementedException();
        }
    }
}
