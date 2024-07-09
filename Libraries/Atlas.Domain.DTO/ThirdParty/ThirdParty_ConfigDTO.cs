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
    public class ThirdParty_ConfigDTO
    {
        [DataMember]
        public Int32 ConfigId { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string MerchantId { get; set; }
        [DataMember]
        public string ProfileId { get; set; }
        [DataMember]
        public string AppId { get; set; }
        [DataMember]
        public BRN_BranchDTO Branch { get; set; }
        [DataMember]
        public ThirdParty_MasterDTO ThirdParty { get; set; }
    }
}
