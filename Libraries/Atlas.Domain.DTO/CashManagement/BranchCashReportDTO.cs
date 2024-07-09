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
    public class BranchCashReportDTO
    {
        [DataMember]
        public long BranchCashReportId { get; set; }
        [DataMember]
        public int BranchId { get; set; }
        [DataMember]
        public long BranchCashAccountId { get; set; }
        [DataMember]
        public string BranchCashAccountNo { get; set; }
        [DataMember]
        public DateTime ReportingDate { get; set; }
        [DataMember]
        public decimal UserReportedBalance { get; set; }
        [DataMember]
        public decimal RepaymentAmount { get; set; }
        [DataMember]
        public decimal OpeningBalance { get; set; }
        [DataMember]
        public decimal ClosingBalance { get; set; }
        [DataMember]
        public decimal Difference { get; set; }
        [DataMember]
        public string Comment { get; set; }
        [DataMember]
        public BOS_StatusDTO Status { get; set; }
        [DataMember]
        public PER_PersonDTO CreatedBy { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }        
        [DataMember]
        public PER_PersonDTO ApprovedBy { get; set; }
        [DataMember]
        public DateTime? ApprovedDate { get; set; }
        [DataMember]
        public List<BranchCashReportSummaryDTO> TransactionSummary;
        [DataMember]
        public List<NuCardCountSummaryDTO> NuCardCountSummary;
        [DataMember]
        public List<BOS_ActionDTO> Actions;
        [DataMember]
        public List<CashDenomination> CashDenominations;
}

    [Serializable]
    [DataContract(IsReference = true)]
    public class BranchCashReportSummaryDTO
    {
        [DataMember]
        public long BranchCashReportId { get; set; }
        [DataMember]
        public string TransactionHead { get; set; }
        [DataMember]
        public decimal TransactionHeadTotal { get; set; }
    }

    [Serializable]
    [DataContract(IsReference = true)]
    public class NuCardCountSummaryDTO
    {
        [DataMember]
        public long BranchCashReportId { get; set; }
        [DataMember]
        public string TransactionHead { get; set; }
        [DataMember]
        public int TransactionHeadTotal { get; set; }
    }

    [Serializable]
    [DataContract(IsReference = true)]
    public class CashDenomination
    {
        [DataMember]
        public decimal Value { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Count { get; set; }
    }
}
