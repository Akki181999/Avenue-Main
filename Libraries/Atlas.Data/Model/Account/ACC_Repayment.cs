using Atlas.Domain.Model.CashManagement;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{

    public sealed class ACC_Repayment : XPCustomObject
    {
        private Int64 _RepaymentId;
        [Key(AutoGenerate = true)]
        public Int64 RepaymentId
        {
            get
            {
                return _RepaymentId;
            }
            set
            {
                SetPropertyValue("RepaymentId", ref _RepaymentId, value);
            }
        }

        private ACC_Account _AccountId;
        [Persistent("AccountId")]
        public ACC_Account Account
        {
            get
            {
                return _AccountId;
            }
            set
            {
                SetPropertyValue("AccountId", ref _AccountId, value);
            }
        }

        private Decimal _RepaymentAmount;
        public Decimal RepaymentAmount
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

        private DateTime _RepaymentDate;
        public DateTime RepaymentDate
        {
            get
            {
                return _RepaymentDate;
            }
            set
            {
                SetPropertyValue("RepaymentDate", ref _RepaymentDate, value);
            }
        }

        private Int32 _CreatedBy;
        public Int32 CreatedBy
        {
            get
            {
                return _CreatedBy;
            }
            set
            {
                SetPropertyValue("CreatedBy", ref _CreatedBy, value);
            }
        }

        private DateTime _CreatedOn;
        public DateTime CreatedOn
        {
            get
            {
                return _CreatedOn;
            }
            set
            {
                SetPropertyValue("CreatedOn", ref _CreatedOn, value);
            }
        }

        private Boolean _bitIsManual;
        public Boolean bitIsManual
        {
            get
            {
                return _bitIsManual;
            }
            set
            {
                SetPropertyValue("bitIsManual", ref _bitIsManual, value);
            }
        }

        private PaymentModes.PaymentModes _PaymentModeId;        
        public PaymentModes.PaymentModes PaymentModeId
        {
            get
            {
                return _PaymentModeId;
            }
            set
            {
                SetPropertyValue("PaymentModeId", ref _PaymentModeId, value);
            }
        }



        private Int64 _CollectionId;
        public Int64 CollectionId
        {
            get
            {
                return _CollectionId;
            }
            set
            {
                SetPropertyValue("CollectionId", ref _CollectionId, value);
            }
        }

        private BOS_Status _Status;
        [Persistent("StatusId")]
        public BOS_Status Status
        {
            get
            {
                return _Status;
            }
            set
            {
                SetPropertyValue("StatusId", ref _Status, value);
            }
        }


        private Int32 _InstallmentNo;
        public Int32 InstallmentNo
        {
            get
            {
                return _InstallmentNo;
            }
            set
            {
                SetPropertyValue("InstallmentNo", ref _InstallmentNo, value);
            }
        }

        private Decimal _UtilizedAmount;
        public Decimal UtilizedAmount
        {
            get
            {
                return _UtilizedAmount;
            }
            set
            {
                SetPropertyValue("UtilizedAmount", ref _UtilizedAmount, value);
            }
        }
        private Decimal _RefundAmount;
        public Decimal RefundAmount
        {
            get
            {
                return _RefundAmount;
            }
            set
            {
                SetPropertyValue("RefundAmount", ref _RefundAmount, value);
            }
        }

        private string _ExtRefNo;
        public string ExtRefNo
        {
            get
            {
                return _ExtRefNo;
            }
            set
            {
                SetPropertyValue("ExtRefNo", ref _ExtRefNo, value);
            }
        }

        private string _Description;
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                SetPropertyValue("Description", ref _Description, value);
            }
        }

        private string _TerminalId;
        public string TerminalId
        {
            get
            {
                return _TerminalId;
            }
            set
            {
                SetPropertyValue("TerminalId", ref _TerminalId, value);
            }
        }

        private DateTime _ValueDate;
        public DateTime ValueDate
        {
            get
            {
                return _ValueDate;
            }
            set
            {
                SetPropertyValue("ValueDate", ref _ValueDate, value);
            }
        }


        private DateTime? _ProcessedOn;
        public DateTime? ProcessedOn
        {
            get
            {
                return _ProcessedOn;
            }
            set
            {
                SetPropertyValue("ApprovedOn", ref _ProcessedOn, value);
            }
        }


        private PER_Person _ProcessedBy;
        public PER_Person ProcessedBy
        {
            get
            {
                return _ProcessedBy;
            }
            set
            {
                SetPropertyValue("ApprovedBy", ref _ProcessedBy, value);
            }
        }
        private Int32 _PaidInstallmentNo;
        public Int32 PaidInstallmentNo
        {
            get
            {
                return _PaidInstallmentNo;
            }
            set
            {
                SetPropertyValue("PaidInstallmentNo", ref _PaidInstallmentNo, value);
            }
        }


        private Boolean _IsEarlySettle;
        public Boolean IsEarlySettle
        {
            get
            {
                return _IsEarlySettle;
            }
            set
            {
                SetPropertyValue("IsEarlySettle", ref _IsEarlySettle, value);
            }
        }
        private Decimal _DiscountedAmount;
        public Decimal DiscountedAmount
        {
            get
            {
                return _DiscountedAmount;
            }
            set
            {
                SetPropertyValue("DiscountedAmount", ref _DiscountedAmount, value);
            }

        }
        private Decimal _VAPPayableAmount;
        public Decimal VAPPayableAmount
        {
            get
            {
                return _VAPPayableAmount;
            }
            set
            {
                SetPropertyValue("VAPPayableAmount", ref _VAPPayableAmount, value);
            }

        }

        private long? _AccPacCollectionId;
        public long? AccPacCollectionId
        {
            get
            {
                return _AccPacCollectionId;
            }
            set
            {
                SetPropertyValue("AccPacCollectionId", ref _AccPacCollectionId, value);
            }
        }

        private long? _DebitOrderId;
        public long? DebitOrderId
        {
            get
            {
                return _DebitOrderId;
            }
            set
            {
                SetPropertyValue("DebitOrderId", ref _DebitOrderId, value);
            }
        }

        private string _TransactionId;
        public string TransactionId
        {
            get
            {
                return _TransactionId;
            }
            set
            {
                SetPropertyValue("TransactionId", ref _TransactionId, value);
            }
        }

        private string _ContractNo;
        public string ContractNo
        {
            get
            {
                return _ContractNo;
            }
            set
            {
                SetPropertyValue("ContractNo", ref _ContractNo, value);
            }
        }

        private BankAccount _regionAccount;
        public BankAccount RegionAccount
        {
            get
            {
                return _regionAccount;
            }
            set
            {
                SetPropertyValue("RegionAccount", ref _regionAccount, value);
            }
        }

        public Int32 CancelPaymentMode { get; set; }

        public Decimal? IDLPAmount { get; set; }

        public Decimal? AdditionalServiceFeeAmount { get; set; }

        public Boolean IsIDLPAcknowledged { get; set; }

        public DateTime? AcceptanceDate { get; set; }

        // add property BranchId

        public Int64? BranchId { get; set; }

        #region Constructors
        public ACC_Repayment() : base() { }
        public ACC_Repayment(Session session) : base(session) { }
        #endregion
    }
}
