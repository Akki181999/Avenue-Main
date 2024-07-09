using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Product
{
    public class PRD_BranchProductMappingDTO
    {
        public long BranchProductMappingId { get; set; }
        public long BranchId { get; set; }
        public long ProductId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int LastUpdatedBy { get; set; }
        public bool IsDefault { get; set; }
    }

}
