using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Account
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class Discount_ReasonMasterDTO
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public string ReasonCode { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
