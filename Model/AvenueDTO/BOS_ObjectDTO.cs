using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Avenue.Model.AvenueDTO
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