using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Common.Models;

namespace Services.Interfaces
{
    public interface IClaimService
    {
        List<ClaimModel> getAll();
        ClaimModel getById(int id);
        ClaimModel Add(ClaimModel ClaimModel);
        ClaimModel Update(ClaimModel ClaimModel);
        void Delete(int id);
    }
}
