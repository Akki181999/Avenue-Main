using System;
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
    public class BOS_NuCardEventHistoryDTO
    {
        [DataMember]
        public Int64 NuCardEventHistoryId { get; set; }
        [DataMember]
        public Int64 NuCardId { get; set; }
        [DataMember]
        public Auth_UserDTO User { get; set; }
        [DataMember]
        public BOS_RoleDTO Role { get; set; }
        [DataMember]
        public BOS_ActionDTO Action { get; set; }
        [DataMember]
        public string Comment { get; set; }
        [DataMember]
        public string FieldsModified { get; set; }
        [DataMember]
        public DateTime ActionDate { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string DisplayName { get; set; }
        [DataMember]
        public Int32 Version { get; set; }
    }
}
