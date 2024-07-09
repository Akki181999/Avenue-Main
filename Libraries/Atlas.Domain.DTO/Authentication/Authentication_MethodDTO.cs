using System;
using System.Runtime.Serialization;

namespace Atlas.Domain.DTO.Authentication
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class Authentication_MethodDTO
    {
        [DataMember]
        public Int64 MethodId { get; set; }
        [DataMember]
        public string Application { get; set; }
        [DataMember]
        public string MethodType { get; set; }
    }
}
