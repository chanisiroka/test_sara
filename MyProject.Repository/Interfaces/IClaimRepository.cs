using MyProject.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository.Interfaces
{
   public interface IClaimRepository
    {
        List<Claim> getAll();
        Claim getById(int id);
        Claim Add(Claim claim);

        Claim Update(Claim claim);
        void Delete(int id);
    }
}
