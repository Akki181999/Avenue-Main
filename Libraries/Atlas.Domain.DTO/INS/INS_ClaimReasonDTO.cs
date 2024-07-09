using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.INS
{
    public class INS_ClaimReasonDTO
    {
      
        public Int64 ClaimReasonId { get; set; }

 
        public char ClaimCode { get; set; }

        public string Description { get; set; }


        public string Category { get; set; }
        public string WaitingPeriod { get; set; }

 
    }
}
