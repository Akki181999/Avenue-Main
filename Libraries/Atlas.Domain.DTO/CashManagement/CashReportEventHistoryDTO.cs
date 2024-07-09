using Atlas.Domain.DTO.Authentication;
using Atlas.Domain.DTO.BOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.CashManagement
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class CashReportEventHistoryDTO
    {
        [DataMember]
        public Int64 CashReportEventHistoryId { get; set; }
        [DataMember]
        public Int32 BranchCashReportId { get; set; }
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
        public Int32 Version { get; set; }
    }
}
