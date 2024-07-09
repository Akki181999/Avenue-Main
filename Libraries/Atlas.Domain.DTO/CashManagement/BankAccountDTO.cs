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
    public class BankAccountDTO
    {

        [DataMember]
        public long BankAccountId { get; set; }

        [DataMember]
        public long Region { get; set; }

        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public int BankCode { get; set; }
        [DataMember]
        public string AccountName { get; set; }
        [DataMember]
        public int CreatedBy { get; set; }
        [DataMember]
        public DateTime? UpdatedDate { get; set; }
        [DataMember]
        public DateTime? CreatedDate { get; set; }
        [DataMember]
        public int UpdatedBy { get; set; }

        [DataMember]
        public List<BOS_ActionDTO> Actions;
    }
}
