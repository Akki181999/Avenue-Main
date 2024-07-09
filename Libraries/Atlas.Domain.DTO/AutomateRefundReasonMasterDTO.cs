using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO
{
    public class AutomateRefundReasonMasterDTO
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string AutomateRefundReason { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}