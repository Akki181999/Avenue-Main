using System;
using System.Runtime.Serialization;

namespace Atlas.Domain.DTO.BOS
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class BOS_ActionDTO
    {
        [DataMember]
        public Int64 ActionId { get; set; }
        [DataMember]
        public string ActionName { get; set; }
        [DataMember]
        public string API { get; set; }
        [DataMember]
        public string AltText { get; set; }
        [DataMember]
        public string DisplayUrl { get; set; }
        public string Name { get; set; }
        [DataMember]
        public string UIURL { get; set; }
        [DataMember]
        public string TransitionFunction { get; set; }
        public int WorkFlowCode { get; set; }
    }
}
