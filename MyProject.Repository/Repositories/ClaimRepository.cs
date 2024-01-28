using MyProject.Repository.Entities;
using MyProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository.Repositories
{
    class ClaimRepository : IClaimRepository
    {
        private readonly IContext context;
        public ClaimRepository(IContext context)
        {
            this.context = context;
        }
        public Claim Add(Claim claim)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Claim> getAll()
        {
            throw new NotImplementedException();
        }

        public Claim getById(int id)
        {
            throw new NotImplementedException();
        }

        public Claim Update(Claim claim)
        {
            throw new NotImplementedException();
        }
    }
}
