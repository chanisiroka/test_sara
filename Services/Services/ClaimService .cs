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
    class ClaimService : IClaimService
    {
        private readonly IClaimRepository ClaimRepository;
        private readonly IMapper mapper;
        public ClaimService(IClaimRepository ClaimRepository,IMapper mapper)
        {
            this.ClaimRepository = ClaimRepository;
            this.mapper = mapper;
        }
        public ClaimModel Add(ClaimModel ClaimModel)
        {
           return mapper.Map<ClaimModel>(ClaimRepository.Add(mapper.Map<Claim>(ClaimModel)));
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ClaimModel> getAll()
        {
            return mapper.Map<List<ClaimModel>>(ClaimRepository.getAll());
        }

        public ClaimModel getById(int id)
        {
            throw new NotImplementedException();
        }

        public ClaimModel Update(ClaimModel ClaimModel)
        {
            throw new NotImplementedException();
        }
    }
}
