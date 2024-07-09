using Atlas.Domain.DTO.ACC_LoanStateReason;
using Atlas.Domain.DTO.BOS;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Atlas.Domain.DTO
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class ACC_AccountDTO
    {
        [DataMember]
        public Int64 AccountId { get; set; }
        [DataMember]
        public string AccountNo { get; set; }
        [DataMember]
        public ACC_AccountTypeDTO AccountType { get; set; }
        [DataMember]
        public PER_PersonDTO Person { get; set; }
        [DataMember]
        public HostDTO Host { get; set; }
        [DataMember]
        public ACC_StatusDTO Status { get; set; }
        [DataMember]
        public Decimal LoanAmount { get; set; }
        [DataMember]
        public Decimal TotalTopUpAmount { get; set; }
        [DataMember]
        public Decimal TotalFees { get; set; }
        [DataMember]
        public Decimal CapitalAmount { get; set; }
        [DataMember]
        public Decimal PayoutAmount { get; set; }
        [DataMember]
        public Decimal? ThirdPartyPayoutAmount { get; set; }
        [DataMember]
        public Decimal AccountBalance { get; set; }
        [DataMember]
        public float InterestRate { get; set; }
        [DataMember]
        public int Period { get; set; }
        [DataMember]
        public ACC_PeriodFrequencyDTO PeriodFrequency { get; set; }
        [DataMember]
        public Decimal InstalmentAmount { get; set; }
        [DataMember]
        public int NumOfInstalments { get; set; }
        [DataMember]
        public ACC_StatusReasonDTO StatusReason { get; set; }
        [DataMember]
        public ACC_StatusSubReasonDTO StatusSubReason { get; set; }
        [DataMember]
        public string NLREnquiryReferenceNo { get; set; }
        [DataMember]
        public string NLRRegistrationNo { get; set; }
        [DataMember]
        public bool IsNLRRegistered { get; set; }
        [DataMember]
        public DateTime StatusChangeDate { get; set; }
        [DataMember]
        public DateTime? FirstInstalmentDate { get; set; }
        [DataMember]
        public DateTime? OpenDate { get; set; }
        [DataMember]
        public DateTime? CloseDate { get; set; }
        [DataMember]
        public DateTime CreateDate { get; set; }
        [DataMember]
        public PER_PersonDTO CreatedBy { get; set; }
        [DataMember]
        public string Comment { get; set; }
        [DataMember]
        public int NewStatusId { get; set; }
        [DataMember]
        public long BranchId { get; set; }
        [DataMember]
        public string HistoryUrl { get; set; }

        [DataMember]
        public char? LoanType { get; set; }

        [DataMember]
        public ACC_LoanStateReasonDTO LoanStateReasonCode { get; set; }

        [DataMember]
        public Account.ExcludePHOLoanReasonDTO ExcludePHOLoanReasonCode { get; set; }

        [DataMember]
        public bool ExcludeFromPHO { get; set; }

        [DataMember]
        public List<BOS_ActionDTO> Actions { get; set; }

        [DataMember]
        public DateTime LoanEndDate { get; set; }

        [DataMember]
        public decimal RepaymentAmount { get; set; }

        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public bool IsUnderPaymentPlan { get; set; } = false;

        [DataMember]
        public Int64 ConsultantApproveBy { get; set; }
        [DataMember]
        public Int64 ManagerApproveBy { get; set; }
        [DataMember]
        public DateTime? ConsultantApproveDate { get; set; }
        [DataMember]
        public DateTime? ManagerApproveDate { get; set; }
        [DataMember]
        public Int64? ProductId { get; set; }

        [DataMember]
        public Int32? CompanyId { get; set; }
        [DataMember]
        public Decimal? RewardAmount { get; set; }

        [DataMember]
        public string IDLPStatus { get; set; }

        [DataMember]
        public DateTime? IDLDDate { get; set; }

        [DataMember]
        public Int64 ParentFlashLoanAccountId { get; set; }

        [DataMember]
        public int VapCancelId { get; set; }

        [DataMember]
        public int VapCancelStatus { get; set; }
    }
}
