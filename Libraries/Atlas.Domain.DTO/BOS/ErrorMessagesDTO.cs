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
    public class ErrorMessagesDTO
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public string ErrorCode { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string ErrorPrefix { get; set; }
    }
}
