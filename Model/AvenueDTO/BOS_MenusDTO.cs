using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Avenue.Model.AvenueDTO
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class BOS_MenusDTO
    {
        [DataMember]
        public Int64 MenuId { get; set; }
        [DataMember]
        public string Key { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string API { get; set; }
        [DataMember]
        public BOS_ObjectDTO Object { get; set; }
        [DataMember]
        public string UIUrl { get; set; }
        [DataMember]
        public int Sequence { get; set; }
        [DataMember]
        public string AltText { get; set; }

    }
}