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
    public  class BOS_AppObjectDTO
    {
        [DataMember]
        public string AppCode { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
