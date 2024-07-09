using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO
{
    public class OverrideOfferReasonMasterDto
    {
        [DataMember]
        public int OverrideOfferReasonId { get; set; }
        [DataMember]
        public string OverrideOfferReason { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}
