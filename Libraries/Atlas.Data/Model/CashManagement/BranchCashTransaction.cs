using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.CashManagement
{
   public class BranchCashTransaction : XPLiteObject
    {
        private long _branchCashTransactionId;
    
        [Key(AutoGenerate = true)]
        [Persistent]
        public long BranchCashTransactionId
        {
            get
            {
                return _branchCashTransactionId;
            }
            set
            {
                _branchCashTransactionId = value;
            }
        }
        
        private int _BranchCashReportId;
        [Persistent]
        public int BranchCashReportId
        {
            get
            {
                return _BranchCashReportId;
            }
            set
            {
                _BranchCashReportId = value;
            }
        }
        private int _BranchCashAccountId;
        [Persistent]
        public int BranchCashAccountId
        {
            get
            {
                return _BranchCashAccountId;
            }
            set
            {
                _BranchCashAccountId = value;
            }
        }
        private int _BranchId;
        [Persistent]
        public int BranchId
        {
            get
            {
                return _BranchId;
            }
            set
            {
                _BranchId = value;
            }
        }
        private DateTime? _ReportingDate;
        [Persistent]
        public DateTime? ReportingDate
        {
            get
            {
                return _ReportingDate;
            }
            set
            {
                SetPropertyValue("ReportingDate", ref _ReportingDate, value);
            }
        }
       

        private DateTime? _TransactionDatee;
        [Persistent]
        public DateTime? TransactionDate
        {
            get
            {
                return _TransactionDatee;
            }
            set
            {
                SetPropertyValue("TransactionDate", ref _TransactionDatee, value);
            }
        }
        private int _TransactionGroupId;
        [Persistent]
        public int TransactionGroupId
        {
            get
            {
                return _TransactionGroupId;
            }
            set
            {
                _TransactionGroupId = value;
            }
        }
        private int _TransactionTypeId;
        [Persistent]
        public int TransactionTypeId
        {
            get
            {
                return _TransactionTypeId;
            }
            set
            {
                _TransactionTypeId = value;
            }
        }
        private string _Comment;
        [Persistent]
        public string Comment
        {
            get
            {
                return _Comment;
            }
            set
            {
                _Comment = value;
            }
        }
        private int _CreditBranchId;
        [Persistent]
        public int CreditBranchId
        {
            get
            {
                return _CreditBranchId;
            }
            set
            {
                _CreditBranchId = value;
            }
        }
        private decimal _TotalAmount;
        [Persistent]
        public decimal TotalAmount
        {
            get
            {
                return _TotalAmount;
            }
            set
            {
                _TotalAmount = value;
            }
        }
        private decimal _TransactionAmount;
        [Persistent]
        public decimal TransactionAmount
        {
            get
            {
                return _TransactionAmount;
            }
            set
            {
                _TransactionAmount = value;
            }
        }
        private decimal _TaxAmount;
        [Persistent]
        public decimal TaxAmount
        {
            get
            {
                return _TaxAmount;
            }
            set
            {
                _TaxAmount = value;
            }
        }
        private int _CreatedBy;
        [Persistent]
        public int CreatedBy
        {
            get
            {
                return _CreatedBy;
            }
            set
            {
                _CreatedBy = value;
            }
        }
        private DateTime _CreatedDate;
        [Persistent]
        public DateTime CreatedDate
        {
            get
            {
                return _CreatedDate;
            }
            set
            {
                SetPropertyValue("CreatedDate", ref _CreatedDate, value);
            }
        }
        private int _UpdateBy;
        [Persistent]
        public int UpdateBy
        {
            get
            {
                return _UpdateBy;
            }
            set
            {
                _UpdateBy = value;
            }
        }
        private DateTime? _UpdatedDate;
        [Persistent]
        public DateTime? UpdatedDate
        {
            get
            {
                return _UpdatedDate;
            }
            set
            {
                SetPropertyValue("UpdatedDate", ref _UpdatedDate, value);
            }
        }
        //private string _CreditAccountType;
        //[Persistent]
        //public string CreditAccountType
        //{
        //    get
        //    {
        //        return _CreditAccountType;
        //    }
        //    set
        //    {
        //        _CreditAccountType = value;
        //    }
        //}
        //private string _idnumber;
        //[Persistent]
        //public string IDNumber
        //{
        //    get
        //    {
        //        return _idnumber;
        //    }
        //    set
        //    {
        //        _idnumber = value;
        //    }
        //}
        //private string _CreditAccountNumber;
        //[Persistent]
        //public string CreditAccountNumber
        //{
        //    get
        //    {
        //        return _CreditAccountNumber;
        //    }
        //    set
        //    {
        //        _CreditAccountNumber = value;
        //    }
        //}
        private long _TransactionRefNumber;
        [Persistent]
        public long TransactionRefNumber
        {
            get
            {
                return _TransactionRefNumber;
            }
            set
            {
                _TransactionRefNumber = value;
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

        private string _AgentCode;
        [Persistent]
        public string AgentCode
        {
            get
            {
                return _AgentCode;
            }
            set
            {
                _AgentCode = value;
            }
        }

        private string _AccountNumber;
        [Persistent]
        public string AccountNumber
        {
            get
            {
                return _AccountNumber;
            }
            set
            {
                _AccountNumber = value;
            }
        }
        private bool _DocumentExist;
        [Persistent]
        public bool DocumentExist
        {
            get
            {
                return _DocumentExist;
            }
            set
            {
                _DocumentExist = value;
            }
        }
        public BranchCashTransaction() : base() { }
        public BranchCashTransaction(Session session) : base(session) { }

    }
}
