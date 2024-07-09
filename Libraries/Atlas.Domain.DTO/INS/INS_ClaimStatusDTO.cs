using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.INS
{
    public class INS_ClaimStatusDTO
    {
        
        public int ClaimStatusId { get; set; }
        
        public char ClaimStatus { get; set; }
        
        public string Description { get; set; }

    }
}
