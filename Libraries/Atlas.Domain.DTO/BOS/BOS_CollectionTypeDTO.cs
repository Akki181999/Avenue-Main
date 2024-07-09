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
    public class BOS_CollectionTypeDTO
    {
        [DataMember]
        public Int64 CollectionTypeId { get; set; }
        [DataMember]
        public string CollectionTypeName { get; set; }
    }
}
