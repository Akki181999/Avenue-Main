using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Atlas.Domain.DTO.BOS
{
    [Serializable]
    [DataContract(IsReference = false)]

    public class BOS_StatusDTO
    {
        [DataMember]
        public Int64 StatusId { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
