using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Atlas.Domain.DTO.BOS;

namespace Atlas.Domain.DTO.CashManagement
{
    [Serializable]
    [DataContract(IsReference = true)]
    public  class BranchCashTransactionDTO
    {
        [DataMember]
        public long BranchCashTransactionId { get; set; }
        [DataMember]
        public int BranchCashReportId { get; set; }
        [DataMember]
        public int BranchCashAccountId { get; set; }
        [DataMember]
        public string BranchCashAccountNo { get; set; }
        [DataMember]
        public int BranchId { get; set; }
        [DataMember]
        public DateTime? ReportingDate { get; set; }
        [DataMember]
        public DateTime? TransactionDate { get; set; }
        [DataMember]
        public int TransactionGroupId { get; set; }
        [DataMember]
        public int TransactionTypeId { get; set; }
        [DataMember]
        public string Comment { get; set; }
        [DataMember]
        public int CreditBranchId { get; set; }
        [DataMember]
        public decimal TotalAmount { get; set; }
        [DataMember]
        public decimal TransactionAmount { get; set; }
        [DataMember]
        public decimal TaxAmount { get; set; }
        [DataMember]
        public int CreatedBy { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
        [DataMember]
        public int UpdateBy { get; set; }
        [DataMember]
        public DateTime? UpdatedDate { get; set; }
        [DataMember]
        public string CreditAccountType { get; set; }
        [DataMember]
        public string CreditAccountNumber { get; set; }
        [DataMember]
        public string IDNumber { get; set; }
        [DataMember]
        public long TransactionRefNo { get; set; }

        [DataMember]
        public string AgentCode { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public BankAccountDTO RegionAccount { get; set; }

        [DataMember]
        public List<BOS_ActionDTO> Actions { get; set; }
    }
}
