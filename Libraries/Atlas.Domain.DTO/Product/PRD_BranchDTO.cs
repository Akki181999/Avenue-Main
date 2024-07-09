using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Product
{
    public class PRD_BranchDTO
    {
        public long ProductId { get; set; }
        public long BranchId { get; set; }
       // public bool IsActive { get; set; }
        public bool IsOverride { get; set; }
        public long ConfigKeyId { get; set; }
        public string ConfigValue { get; set; }
    }
}
