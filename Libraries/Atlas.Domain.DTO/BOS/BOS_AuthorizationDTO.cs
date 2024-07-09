using Atlas.Domain.DTO.Authentication;
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
    public class BOS_AuthorizationDTO
    {
        [DataMember]
        public Int64 AuthorizationId { get; set; }
        [DataMember]
        public string Application { get; set; }
        [DataMember]
        public Auth_UserDTO User { get; set; }
        [DataMember]
        public BOS_RoleDTO Role { get; set; }
        [DataMember]
        public BRN_BranchDTO Branch { get; set; }
        [DataMember]
        public bool IsDefault { get; set; }
        [DataMember]
        public List<BOS_ActionDTO> Action { get; set; }
        public object Data { get; set; }
        [DataMember]
        public bool CanSelfApprove { get; set; }
        [DataMember]
        public DateTime? FromDT { get; set; }
        [DataMember]
        public DateTime? ToDT { get; set; }
        [DataMember]
        public Int64? CompanyId { get; set; }
        [DataMember]
        public string CompanyName { get; set; }

    }
}
