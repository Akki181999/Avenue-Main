using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class BOS_ObjectDTO
    {
        [DataMember]
        public Int64 ObjectId { get; set; }
        [DataMember]
        public string ObjectName { get; set; }
    }
}
