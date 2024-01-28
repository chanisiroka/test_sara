using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.Models
{
  public  enum ePolicy { Deny,Allow}
    public class ClaimModel
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public ePolicy Policy { get; set; }
    }
}
