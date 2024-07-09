using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public class ACC_ChangeDebitOrder : XPLiteObject
    {
        private Int64 _changeDebitOrderId;
        [Key(AutoGenerate = true)]
        public Int64 ChangeDebitOrderId
        {
            get
            {
                return _changeDebitOrderId;
            }
            set
            {
                SetPropertyValue("ChangeDebitOrderId", ref _changeDebitOrderId, value);
            }
        }

        private bool _changeBankDetail = false;
        [Persistent]
        public bool ChangeBankDetail
        {
            get
            {
                return _changeBankDetail;
            }
            set
            {
                SetPropertyValue("ChangeBankDetail", ref _changeBankDetail, value);
            }
        }

        private bool _createPaymentPlan = false;
        [Persistent]
        public bool CreatePaymentPlan
        {
            get
            {
                return _createPaymentPlan;
            }
            set
            {
                SetPropertyValue("CreatePaymentPlan", ref _createPaymentPlan, value);
            }
        }

        private Int64 _bankDetailId;
        public Int64 BankDetailId
        {
            get
            {
                return _bankDetailId;
            }
            set
            {
                SetPropertyValue("BankDetailId", ref _bankDetailId, value);
            }
        }

        private Int64 _applicationId;
        public Int64 ApplicationId
        {
            get
            {
                return _applicationId;
            }
            set
            {
                SetPropertyValue("ApplicationId", ref _applicationId, value);
            }
        }

        private Int64 _accountId;
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

        private Int64 _frequencyTypeId;
        public Int64 FrequencyTypeId
        {
            get
            {
                return _frequencyTypeId;
            }
            set
            {
                SetPropertyValue("FrequencyTypeId", ref _frequencyTypeId, value);
            }
        }

        private string _payDay;
        [Persistent]
        public string PayDay
        {
            get
            {
                return _payDay;
            }
            set
            {
                SetPropertyValue("PayDay", ref _payDay, value);
            }
        }

        private Decimal _outstandingBalance;
        [Persistent]
        public Decimal OutstandingBalance
        {
            get
            {
                return _outstandingBalance;
            }
            set
            {
                SetPropertyValue("OutstandingBalance", ref _outstandingBalance, value);
            }
        }

        private Int64 _term;
        public Int64 Term
        {
            get
            {
                return _term;
            }
            set
            {
                SetPropertyValue("Term", ref _term, value);
            }
        }

        private Decimal _installmentAmount;
        [Persistent]
        public Decimal InstallmentAmount
        {
            get
            {
                return _installmentAmount;
            }
            set
            {
                SetPropertyValue("InstallmentAmount", ref _installmentAmount, value);
            }
        }

        private DateTime _firstRepaymentDate;
        [Persistent]
        public DateTime FirstRepaymentDate
        {
            get
            {
                return _firstRepaymentDate;
            }
            set
            {
                SetPropertyValue("FirstRepaymentDate", ref _firstRepaymentDate, value);
            }
        }

        private string _tCCTerminalId;
        [Persistent]
        public string TCCTerminalId
        {
            get
            {
                return _tCCTerminalId;
            }
            set
            {
                SetPropertyValue("TCCTerminalId", ref _tCCTerminalId, value);
            }
        }

        private Int64 _cancelledDebitOrderId;
        public Int64 CancelledDebitOrderId
        {
            get
            {
                return _cancelledDebitOrderId;
            }
            set
            {
                SetPropertyValue("CancelledDebitOrderId", ref _cancelledDebitOrderId, value);
            }
        }

        private Int64 _newDebitOrderId;
        public Int64 NewDebitOrderId
        {
            get
            {
                return _newDebitOrderId;
            }
            set
            {
                SetPropertyValue("NewDebitOrderId", ref _newDebitOrderId, value);
            }
        }

        private Int64 _branchId;
        public Int64 BranchId
        {
            get
            {
                return _branchId;
            }
            set
            {
                SetPropertyValue("BranchId", ref _branchId, value);
            }
        }

        private Int64 _createdBy;
        public Int64 CreatedBy
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
        private Int64 _StatusId;
        public Int64 StatusId
        {
            get
            {
                return _StatusId;
            }
            set
            {
                SetPropertyValue("StatusId", ref _StatusId, value);
            }
        }
        private Int64 _DebitOrderModeId;
        public Int64 DebitOrderModeId
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


        #region Constructors

        public ACC_ChangeDebitOrder() : base() { }
        public ACC_ChangeDebitOrder(Session session) : base(session) { }

        #endregion
    }
}
