using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.INS
{
    public class INS_ClaimRejectionReasonDTO
    {
      
        public int RejectReasonId { get; set; }
        
        public string RejectCode { get; set; }
       
        public string Description { get; set; }
    }
}
