using Atlas.Domain.Model.Account;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public sealed class ACC_Account : XPCustomObject
    {
        private Int64 _accountId;
        [Key(AutoGenerate = true)]
        public Int64 AccountId
        {
            get
            {
                return _accountId;
            }
            set
            {
                SetPropertyValue("AccountId", ref _accountId, value);
            }
        }

        private string _accountNo;
        [Indexed]
        [Persistent, Size(13)]
        public string AccountNo
        {
            get
            {
                return _accountNo;
            }
            set
            {
                SetPropertyValue("AccountNo", ref _accountNo, value);
            }
        }

        private ACC_AccountType _accountType;
        [Persistent("AccountTypeId")]
        public ACC_AccountType AccountType
        {
            get
            {
                return _accountType;
            }
            set
            {
                SetPropertyValue("AccountType", ref _accountType, value);
            }
        }

        private PER_Person _person;
        [Persistent("PersonId")]
        public PER_Person Person
        {
            get
            {
                return _person;
            }
            set
            {
                SetPropertyValue("Person", ref _person, value);
            }
        }

        private Host _host;
        [Persistent("HostId")]
        public Host Host
        {
            get
            {
                return _host;
            }
            set
            {
                SetPropertyValue("Host", ref _host, value);
            }
        }

        private ACC_Status _status;
        [Persistent("StatusId")]
        public ACC_Status Status
        {
            get
            {
                return _status;
            }
            set
            {
                SetPropertyValue("Status", ref _status, value);
            }
        }

        private Decimal _loanAmount;
        [Persistent]
        public Decimal LoanAmount
        {
            get
            {
                return _loanAmount;
            }
            set
            {
                SetPropertyValue("LoanAmount", ref _loanAmount, value);
            }
        }

        private Decimal _totalTopUpAmount;
        [Persistent]
        public Decimal TotalTopUpAmount
        {
            get
            {
                return _totalTopUpAmount;
            }
            set
            {
                SetPropertyValue("TotalTopUpAmount", ref _totalTopUpAmount, value);
            }
        }

        private Decimal _totalFees;
        [Persistent]
        public Decimal TotalFees
        {
            get
            {
                return _totalFees;
            }
            set
            {
                SetPropertyValue("TotalFees", ref _totalFees, value);
            }
        }

        private Decimal _capitalAmount;
        [Persistent]
        public Decimal CapitalAmount
        {
            get
            {
                return _capitalAmount;
            }
            set
            {
                SetPropertyValue("CapitalAmount", ref _capitalAmount, value);
            }
        }

        private Decimal _payoutAmount;
        [Persistent]
        public Decimal PayoutAmount
        {
            get
            {
                return _payoutAmount;
            }
            set
            {
                SetPropertyValue("PayoutAmount", ref _payoutAmount, value);
            }
        }

        private Decimal? _thirdPartyPayoutAmount;
        [Persistent]
        public Decimal? ThirdPartyPayoutAmount
        {
            get
            {
                return _thirdPartyPayoutAmount;
            }
            set
            {
                SetPropertyValue("ThirdPartyPayoutAmount", ref _thirdPartyPayoutAmount, value);
            }
        }

        private Decimal _accountBalance;
        [Persistent]
        public Decimal AccountBalance
        {
            get
            {
                return _accountBalance;
            }
            set
            {
                SetPropertyValue("AccountBalance", ref _accountBalance, value);
            }
        }

        private float _interestRate;
        [Persistent]
        public float InterestRate
        {
            get
            {
                return _interestRate;
            }
            set
            {
                SetPropertyValue("InterestRate", ref _interestRate, value);
            }
        }

        private int _period;
        [Persistent]
        public int Period
        {
            get
            {
                return _period;
            }
            set
            {
                SetPropertyValue("Period", ref _period, value);
            }
        }

        private ACC_PeriodFrequency _periodFrequency;
        [Persistent("PeriodFrequencyId")]
        public ACC_PeriodFrequency PeriodFrequency
        {
            get
            {
                return _periodFrequency;
            }
            set
            {
                SetPropertyValue("PeriodFrequency", ref _periodFrequency, value);
            }
        }

        private Decimal _instalmentAmount;
        [Persistent]
        public Decimal InstalmentAmount
        {
            get
            {
                return _instalmentAmount;
            }
            set
            {
                SetPropertyValue("InstalmentAmount", ref _instalmentAmount, value);
            }
        }

        private int _numOfInstalments;
        [Persistent]
        public int NumOfInstalments
        {
            get
            {
                return _numOfInstalments;
            }
            set
            {
                SetPropertyValue("NumOfInstalments", ref _numOfInstalments, value);
            }
        }

        private ACC_StatusReason _statusReason;
        [Persistent("StatusReasonId")]
        public ACC_StatusReason StatusReason
        {
            get
            {
                return _statusReason;
            }
            set
            {
                SetPropertyValue("StatusReason", ref _statusReason, value);
            }
        }

        private ACC_StatusSubReason _statusSubReason;
        [Persistent("StatusSubReasonId")]
        public ACC_StatusSubReason StatusSubReason
        {
            get
            {
                return _statusSubReason;
            }
            set
            {
                SetPropertyValue("StatusSubReason", ref _statusSubReason, value);
            }
        }

        //private Enumerators.Account.ScoreResult _scoreResult;
        //[Persistent("ScoreResultId")]
        //public Enumerators.Account.ScoreResult ScoreResult
        //{
        //  get
        //  {
        //    return _scoreResult;
        //  }
        //  set
        //  {
        //    SetPropertyValue("ScoreResult", ref _scoreResult, value);
        //  }
        //}

        //private ACC_ScoreCard _scoreCard;
        //[Persistent("ScoreCardId")]
        //public ACC_ScoreCard ScoreCard
        //{
        //  get
        //  {
        //    return _scoreCard;
        //  }
        //  set
        //  {
        //    SetPropertyValue("ScoreCard", ref _scoreCard, value);
        //  }
        //}

        private string _nlrEnquiryReferenceNo;
        [Persistent]
        public string NLREnquiryReferenceNo
        {
            get
            {
                return _nlrEnquiryReferenceNo;
            }
            set
            {
                SetPropertyValue("NLREnquiryReferenceNo", ref _nlrEnquiryReferenceNo, value);
            }
        }

        private string _nlrRegistrationNo;
        [Persistent]
        public string NLRRegistrationNo
        {
            get
            {
                return _nlrRegistrationNo;
            }
            set
            {
                SetPropertyValue("NLRRegistrationNo", ref _nlrRegistrationNo, value);
            }
        }

        private bool _isNLRRegistered;
        [Persistent]
        public bool IsNLRRegistered
        {
            get
            {
                return _isNLRRegistered;
            }
            set
            {
                SetPropertyValue("IsNLRRegistered", ref _isNLRRegistered, value);
            }
        }

        private DateTime _statusChangeDate;
        [Persistent]
        public DateTime StatusChangeDate
        {
            get
            {
                return _statusChangeDate;
            }
            set
            {
                SetPropertyValue("StatusChangeDate", ref _statusChangeDate, value);
            }
        }

        private DateTime? _firstInstalmentDate;
        [Persistent]
        public DateTime? FirstInstalmentDate
        {
            get
            {
                return _firstInstalmentDate;
            }
            set
            {
                SetPropertyValue("FirstInstalmentDate", ref _firstInstalmentDate, value);
            }
        }

        private DateTime? _openDate;
        [Persistent]
        public DateTime? OpenDate
        {
            get
            {
                return _openDate;
            }
            set
            {
                SetPropertyValue("OpenDate", ref _openDate, value);
            }
        }

        private DateTime? _closeDate;
        [Persistent]
        [Indexed]
        public DateTime? CloseDate
        {
            get
            {
                return _closeDate;
            }
            set
            {
                SetPropertyValue("CloseDate", ref _closeDate, value);
            }
        }

        private DateTime _createDate;
        [Persistent]
        public DateTime CreateDate
        {
            get
            {
                return _createDate;
            }
            set
            {
                SetPropertyValue("CreateDate", ref _createDate, value);
            }
        }

        private PER_Person _createdBy;
        [Persistent]
        public PER_Person CreatedBy
        {
            get
            {
                return _createdBy;
            }
            set
            {
                SetPropertyValue("CreatedBy", ref _createdBy, value);
            }
        }

        private int _NewStatusId = 0;
        public int NewStatusId
        {
            get
            {
                return _NewStatusId;
            }
            set
            {
                SetPropertyValue("NewStatusId", ref _NewStatusId, value);
            }
        }

        //public long? BranchId { get; set; }

        private long? branchId;
        [Persistent]
        public long? BranchId
        {
            get
            {
                return branchId;
            }
            set
            {
                SetPropertyValue("BranchId", ref branchId, value);
            }
        }

        private char? _LoanType;
        [Persistent]
        public char? LoanType
        {
            get
            {
                return _LoanType;
            }
            set
            {
                SetPropertyValue("LoanType", ref _LoanType, value);
            }
        }

        private DateTime _paidDate;
        [Persistent]
        public DateTime PaidDate
        {
            get
            {
                return _paidDate;
            }
            set
            {
                SetPropertyValue("PaidDate", ref _paidDate, value);
            }
        }

        private ACC_LoanStateReason _code;
        [Persistent("LoanStateReasonCode")]
        public ACC_LoanStateReason LoanStateReasonCode
        {
            get
            {
                return _code;
            }
            set
            {
                SetPropertyValue("LoanStateReasonCode", ref _code, value);
            }
        }

        private decimal _DiscountAmount;
        [Persistent]
        public decimal DiscountAmount
        {
            get
            {
                return _DiscountAmount;
            }
            set
            {
                SetPropertyValue("DiscountAmount", ref _DiscountAmount, value);
            }
        }
        private Int64 _RollOverAccountId;
        [Persistent]
        public Int64 RollOverAccountId
        {
            get
            {
                return _RollOverAccountId;
            }
            set
            {
                SetPropertyValue("RollOverAccountId", ref _RollOverAccountId, value);
            }
        }

        private ExcludePHOLoanReason _ExcludePHOLoanReasonCode;
        [Persistent]
        public ExcludePHOLoanReason ExcludePHOLoanReasonCode
        {
            get
            {
                return _ExcludePHOLoanReasonCode;
            }
            set
            {
                SetPropertyValue("ExcludePHOLoanReasonCode", ref _ExcludePHOLoanReasonCode, value);
            }
        }

        private decimal _HandoverAmount;
        [Persistent]
        public decimal HandoverAmount
        {
            get
            {
                return _HandoverAmount;
            }
            set
            {
                SetPropertyValue("HandoverAmount", ref _HandoverAmount, value);
            }
        }

        private DateTime? _HandoverDate;
        [Persistent]
        public DateTime? HandoverDate
        {
            get
            {
                return _HandoverDate;
            }
            set
            {
                SetPropertyValue("HandoverDate", ref _HandoverDate, value);
            }
        }

        private DateTime? _HandoverDueDate;
        [Persistent]
        public DateTime? HandoverDueDate
        {
            get
            {
                return _HandoverDueDate;
            }
            set
            {
                SetPropertyValue("HandoverDueDate", ref _HandoverDueDate, value);
            }
        }

        private bool _ExcludeFromPHO;
        [Persistent]
        public bool ExcludeFromPHO
        {
            get
            {
                return _ExcludeFromPHO;
            }
            set
            {
                SetPropertyValue("ExcludeFromPHO", ref _ExcludeFromPHO, value);
            }
        }

        private decimal _HandoverServiceFee;
        [Persistent]
        public decimal HandoverServiceFee
        {
            get
            {
                return _HandoverServiceFee;
            }
            set
            {
                SetPropertyValue("HandoverServiceFee", ref _HandoverServiceFee, value);
            }
        }

        private DateTime _LoanEndDate;
        [Persistent]
        public DateTime LoanEndDate
        {
            get
            {
                return _LoanEndDate;
            }
            set
            {
                SetPropertyValue("LoanEndDate", ref _LoanEndDate, value);
            }
        }

        private decimal _RepaymentAmount;
        [Persistent]
        public decimal RepaymentAmount
        {
            get
            {
                return _RepaymentAmount;
            }
            set
            {
                SetPropertyValue("RepaymentAmount", ref _RepaymentAmount, value);
            }
        }

        private int _ClientId;
        [Persistent]
        public int ClientId
        {
            get
            {
                return _ClientId;
            }
            set
            {
                SetPropertyValue("ClientId", ref _ClientId, value);
            }
        }


        private decimal _VAP_CST;
        [Persistent]
        public decimal VAP_CST
        {
            get
            {
                return _VAP_CST;
            }
            set
            {
                SetPropertyValue("VAP_CST", ref _VAP_CST, value);
            }
        }


        private decimal _FUN_CST;
        [Persistent]
        public decimal FUN_CST
        {
            get
            {
                return _FUN_CST;
            }
            set
            {
                SetPropertyValue("FUN_CST", ref _FUN_CST, value);
            }
        }

        private int _DisbursementModeId;
        [Persistent]
        public int DisbursementModeId
        {
            get
            {
                return _DisbursementModeId;
            }
            set
            {
                SetPropertyValue("DisbursementModeId", ref _DisbursementModeId, value);
            }
        }

        private int _DebitOrderModeId;
        [Persistent]
        public int DebitOrderModeId
        {
            get
            {
                return _DebitOrderModeId;
            }
            set
            {
                SetPropertyValue("DebitOrderModeId", ref _DebitOrderModeId, value);
            }
        }
        private bool _IsUnderPaymentPlan;
        [Persistent]
        public bool IsUnderPaymentPlan
        {
            get
            {
                return _IsUnderPaymentPlan;
            }
            set
            {
                SetPropertyValue("IsUnderPaymentPlan", ref _IsUnderPaymentPlan, value);
            }
        }
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
        public string IDLPStatus { get; set; }

        [Persistent]
        public DateTime? IDLDDate { get; set; }

        [Persistent]
        public  Int64 ParentFlashLoanAccountId { get; set; }

        [Persistent]
        public Decimal? RepoRate { get; set; }
        [Persistent]
        public Decimal? RepoRateFactor { get; set; }
        [Persistent]
        public Decimal? RepoRateAdjustment { get; set; }

        [Persistent]
        public bool? IsUnsecuredLoan { get; set; }

        [Persistent]
        public int VapCancelId { get; set; }
        [Persistent]
        public int VapCancelStatus { get; set; }

        [Association]
        public XPCollection<WFL_ProcessStepJobAccount> ProcessStepJobAccounts { get { return GetCollection<WFL_ProcessStepJobAccount>("ProcessStepJobAccounts"); } }

        [Association]
        public XPCollection<PYT_Payout> Payouts { get { return GetCollection<PYT_Payout>("Payouts"); } }

        [Association]
        public XPCollection<ACC_History> History { get { return GetCollection<ACC_History>("History"); } }

        [Association]
        public XPCollection<ACC_AccountPolicy> Policies { get { return GetCollection<ACC_AccountPolicy>("Policies"); } }
        [Association]
        public XPCollection<ACC_AccountPayRule> AccountPayRules { get { return GetCollection<ACC_AccountPayRule>("AccountPayRules"); } }

        #region Constructors

        public ACC_Account() : base() { }
        public ACC_Account(Session session) : base(session) { }

        #endregion
    }
}
