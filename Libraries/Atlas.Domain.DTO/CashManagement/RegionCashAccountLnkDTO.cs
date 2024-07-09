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
    public class RegionCashAccountLnkDTO
    {
        [DataMember]
        public long RegionCashAccountLnkId { get; set; }
        [DataMember]
        public int BranchId { get; set; }
        [DataMember]
        public long BranchCashAccountId { get; set; }
        [DataMember]
        public long BankAccountId { get; set; }
        [DataMember]
        public int CreatedBy { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
        [DataMember]
        public int UpdatedBy { get; set; }
        [DataMember]
        public DateTime? UpdatedDate { get; set; }
        
        [DataMember]
        public List<BOS_ActionDTO> Actions;
    }
}
