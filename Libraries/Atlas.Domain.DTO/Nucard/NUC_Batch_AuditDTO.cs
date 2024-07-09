using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Atlas.Domain.DTO.BOS;

namespace Atlas.Domain.DTO.Nucard
{
    [Serializable]
    [DataContract(IsReference = false)]

    public class NUC_Batch_AuditDTO
    {
        [DataMember]
        public Int64 AuditId { get; set; }
        [DataMember]
        public NUC_BatchDto BatchId { get; set; }
        [DataMember]
        public BOS_ActionDTO ActionId { get; set; }
        [DataMember]
        public PER_PersonDTO ActionBy { get; set; }
        [DataMember]
        public DateTime ActionDT { get; set; }
    }
}
