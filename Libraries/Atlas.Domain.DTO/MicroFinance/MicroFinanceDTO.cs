using Atlas.Domain.DTO.BOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.MicroFinance
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class MicroFinanceDTO
    {
        [DataMember]
        public long MicroFinanceId { get; set; }
        [DataMember]
        public string CompanyName { get; set; }
        [DataMember]
        public int CreatedBy { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
        [DataMember]
        public int ApprovedBy { get; set; }
        [DataMember]
        public DateTime ApprovedDate { get; set; }
        [DataMember]
        public Int32 BankCode { get; set; }
        [DataMember]
        public string AccountNo { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string VerifiedName { get; set; } = "N";
        [DataMember]
        public string VerifiedIDNumber { get; set; } = "N";
        [DataMember]
        public int AccountType { get; set; } = 1;
        [DataMember]
        public string TradingName { get; set; }
        [DataMember]
        public string  DisbursementType { get; set; }

        [DataMember]
        public List<BOS_ActionDTO> Actions;
    }
}