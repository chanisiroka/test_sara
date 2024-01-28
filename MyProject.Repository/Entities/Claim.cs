using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repository.Entities
{
   public enum ePolicy { Deny,Allow}
   public class Claim
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public ePolicy Policy { get; set; }
    }
}
