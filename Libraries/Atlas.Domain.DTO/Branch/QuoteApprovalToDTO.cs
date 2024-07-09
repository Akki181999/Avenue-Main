using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Atlas.Domain.DTO.Branch
{
    public class QuoteApprovalToDTO
    {
        [DataMember]
        public Int64 QuoteApprovalRequiredToId { get; set; }
        [DataMember]
        public string QuoteApprovalRequiredTo { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}
