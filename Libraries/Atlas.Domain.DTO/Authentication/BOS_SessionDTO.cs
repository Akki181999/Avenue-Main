using Atlas.Domain.DTO.BOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Authentication
{

    [Serializable]
    [DataContract(IsReference = true)]
    public class BOS_SessionDTO
    {
        [DataMember]
        public Int64 SessionId { get; set; }
        [DataMember]
        public string Token { get; set; }
        [DataMember]
        public DateTime Expiry { get; set; }
        [DataMember]
        public Auth_UserDTO User { get; set; }
        [DataMember]
        public BOS_RoleDTO Role { get; set; }

        [DataMember]
        public DateTime LoginTime { get; set; }
        [DataMember]
        public DateTime? LogoutTime { get; set; }
        [DataMember]
        public string BrowserInfo { get; set; }
        [DataMember]
        public string MachineIp { get; set; }
        [DataMember]
        public string ScreenResolution { get; set; }
        [DataMember]
        public bool IsMannualLogout { get; set; }

        [DataMember]
        public BRN_BranchDTO Branch { get; set; }

        [DataMember]
        public string AppId { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public bool IsChangePasswordCheck { get; set; }

        [DataMember]
        public Int64? CompanyId { get; set; }

        [DataMember]
        public string CompanyName { get; set; }
    }
}
