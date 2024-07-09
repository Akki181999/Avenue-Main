using Atlas.Domain.DTO.BOS;
using Atlas.Domain.Model;
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
    public class BranchCashAccountDTO
    {
        [DataMember]
        public long BranchCashAccountId { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public string AccountName { get; set; }
        [DataMember]
        public int BranchId { get; set; }
        [DataMember]
        public int CreatedBy { get; set; }
        [DataMember]
        public DateTime CreateDate { get; set; }
        [DataMember]
        public DateTime? UpdatedDate { get; set; }
        [DataMember]
        public int UpdatedBy { get; set; }
        [DataMember]
        public List<BOS_ActionDTO> Actions;

    }
}
