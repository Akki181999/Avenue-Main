using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public class AuthorizationData
    {
        public string AppId { get; set; }
        public long UserId { get; set; }
        public long BranchId { get; set; }
        public long RoleId { get; set; }
    }
}
