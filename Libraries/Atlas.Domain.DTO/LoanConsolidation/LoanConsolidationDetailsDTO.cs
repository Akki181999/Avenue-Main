using Atlas.Domain.DTO.BOS;
using Atlas.Domain.DTO.MicroFinance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.LoanConsolidation
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class LoanConsolidationDetailsDTO
    {
        [DataMember]
        public Int64 LoanConsolidationDetailsId { get; set; }
        [DataMember]
        public Int32 MicroFinanceId { get; set; }
        [DataMember]
        public string ReferenceNumber { get; set; }
        [DataMember]
        public DateTime CreateDate { get; set; }
        [DataMember]
        public Int64 CreatedBy { get; set; }
        [DataMember]
        public DateTime ExpiryDate { get; set; }
        [DataMember]
        public DateTime NextDebitOrderDate { get; set; }
       
        [DataMember]
        public DateTime VerifiedDate { get; set; }
        [DataMember]
        public Int64 VerifiedBy { get; set; }
        [DataMember]
        public int Status { get; set; }
        [DataMember]
        public decimal SettlementAmount { get; set; }
        [DataMember]
        public Int64 ApplicationId { get; set; }
        [DataMember]

        public MicroFinanceDTO MicroFinance { get; set; }



        public List<BOS_ActionDTO> Actions;
    }
}
