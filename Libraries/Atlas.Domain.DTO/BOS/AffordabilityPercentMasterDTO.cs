using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.BOS
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class AffordabilityPercentMasterDTO
    {
        [DataMember]
        public Int32 Id { get; set; }
        [DataMember]
        public Int32 AffordabilityPercent { get; set; }
    }
}
