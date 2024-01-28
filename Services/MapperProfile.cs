using AutoMapper;
using MyProject.Common.Models;
using MyProject.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Role, RoleModel>().ReverseMap();
           // CreateMap<RoleModel, Role>();
            CreateMap<Claim, ClaimModel>();
            CreateMap<ClaimModel, Claim>();
            CreateMap<Permission, PermissionModel>();
            CreateMap<PermissionModel, Permission>();
        }
    }
}
