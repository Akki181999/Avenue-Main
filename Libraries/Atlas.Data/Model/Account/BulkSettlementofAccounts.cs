using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public class BulkSettlementofAccounts : XPLiteObject
    {
        #region Constructors
        public BulkSettlementofAccounts() : base() { }
        public BulkSettlementofAccounts(Session session) : base(session) { }

        #endregion

        [Key(AutoGenerate = true)]
        public Int64 BulkSettlementAccountId { get; set; }
        [Persistent]
        public Int64 AutoWriteOffId { get; set; }
        public Int64 AccountId { get; set; }
        [Persistent]
        public string AccountNo { get; set; }
        [Persistent]
        public Int64 AccountTypeId { get; set; }
        [Persistent]
        public Int64 PersonId { get; set; }
        [Persistent]
        public Int32 HostId { get; set; }
        [Persistent]
        public string Status { get; set; }
        [Persistent]
        public Decimal LoanAmount { get; set; }
        [Persistent]
        public Decimal TotalTopUpAmount { get; set; }
        [Persistent]
        public Decimal TotalFees { get; set; }
        [Persistent]
        public Decimal CapitalAmount { get; set; }
        [Persistent]
        public Decimal PayoutAmount { get; set; }
        [Persistent]
        public Decimal? ThirdPartyPayoutAmount { get; set; }
        [Persistent]
        public Decimal AccountBalance { get; set; }
        [Persistent]
        public float InterestRate { get; set; }
        [Persistent]
        public int Period { get; set; }
        [Persistent]
        public Int32 PeriodFrequencyId { get; set; }
        [Persistent]
        public Decimal InstalmentAmount { get; set; }
        [Persistent]
        public int NumOfInstalments { get; set; }
        [Persistent]
        public Int64 StatusReasonId { get; set; }
        [Persistent]
        public Int64 StatusSubReasonId { get; set; }
        [Persistent]
        public string NLREnquiryReferenceNo { get; set; }
        [Persistent]
        public string NLRRegistrationNo { get; set; }
        [Persistent]
        public bool IsNLRRegistered { get; set; }
        [Persistent]
        public DateTime StatusChangeDate { get; set; }
        [Persistent]
        public DateTime? FirstInstalmentDate { get; set; }
        [Persistent]
        public DateTime? OpenDate { get; set; }
        [Persistent]
        public DateTime? CloseDate { get; set; }
        [Persistent]
        public DateTime CreateDate { get; set; }
        [Persistent]
        public Int64 CreatedBy { get; set; }
        [Persistent]
        public string Comment { get; set; }
        [Persistent]
        public int NewStatusId { get; set; }
        [Persistent]
        public long BranchId { get; set; }
        [Persistent]
        public string HistoryUrl { get; set; }

        [Persistent]
        public char? LoanType { get; set; }

        [Persistent]
        public string LoanStateReasonCode { get; set; }

        [Persistent]
        public string ExcludePHOLoanReasonCode { get; set; }

        [Persistent]
        public bool ExcludeFromPHO { get; set; }



        [Persistent]
        public DateTime LoanEndDate { get; set; }

        [Persistent]
        public decimal RepaymentAmount { get; set; }

        [Persistent]
        public int ClientId { get; set; }
        [Persistent]
        public bool IsUnderPaymentPlan { get; set; } = false;

        [Persistent]
        public Int64 ConsultantApproveBy { get; set; }
        [Persistent]
        public Int64 ManagerApproveBy { get; set; }
        [Persistent]
        public DateTime? ConsultantApproveDate { get; set; }
        [Persistent]
        public DateTime? ManagerApproveDate { get; set; }
        [Persistent]
        public Int64? ProductId { get; set; }

        [Persistent]
        public Int32? CompanyId { get; set; }
        [Persistent]
        public Decimal? RewardAmount { get; set; }

        [Persistent]
        public bool? IsReferred { get; set; }

        [Persistent]
        public Decimal? ReferralAmount { get; set; }

        [Persistent]
        public string SettlementStatus { get; set; }

        [Persistent]
        public DateTime? ProcessDate { get; set; }
    }
}
