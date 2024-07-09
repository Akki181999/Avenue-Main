using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.ThirdParty
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class ThirdParty_MasterDTO
    {
        [DataMember]
        public Int64 ThirdPartyId { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
