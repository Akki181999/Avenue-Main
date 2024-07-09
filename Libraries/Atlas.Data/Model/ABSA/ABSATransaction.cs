using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atlas.Domain.Model.ABSA
{
   public class ABSATransaction : XPLiteObject
    {
        private int _transactionId;
        [Persistent]
        [Key(AutoGenerate = true)]
        public int TransactionId
        {
            get
            {
                return _transactionId;
            }
            set
            {
                SetPropertyValue("TransactionId", ref _transactionId, value);
            }
        }
        private int _transmissionNumber;
        [Persistent]
        public int TransmissionNumber
        {
            get
            {
                return _transmissionNumber;
            }
            set
            {
                SetPropertyValue("TransmissionNumber", ref _transmissionNumber, value);
            }
        }
        private string _recordIdentifier;
        [Persistent]
        public string RecordIdentifier
        {
            get
            {
                return _recordIdentifier;
            }
            set
            {
                SetPropertyValue("RecordIdentifier", ref _recordIdentifier, value);
            }
        }
        private string _dataSetStatus;
        [Persistent]
        public string DataSetStatus
        {
            get
            {
                return _dataSetStatus;
            }
            set
            {
                SetPropertyValue("DataSetStatus", ref _dataSetStatus, value);
            }
        }
        private string _bankservRecordIdentifier;
        [Persistent]
        public string BankservRecordIdentifier
        {
            get
            {
                return _bankservRecordIdentifier;
            }
            set
            {
                SetPropertyValue("BankservRecordIdentifier", ref _bankservRecordIdentifier, value);
            }
        }
        private int _userBranch;
        [Persistent]
        public int UserBranch
        {
            get
            {
                return _userBranch;
            }
            set
            {
                SetPropertyValue("UserBranch", ref _userBranch, value);
            }
        }
        private string _userNominatedAccount;
        [Persistent]
        public string UserNominatedAccount
        {
            get
            {
                return _userNominatedAccount;
            }
            set
            {
                SetPropertyValue("UserNominatedAccount", ref _userNominatedAccount, value);
            }
        }
        private string _userCode;
        [Persistent]
        public string UserCode
        {
            get
            {
                return _userCode;
            }
            set
            {
                SetPropertyValue("UserCode", ref _userCode, value);
            }
        }
        private int _userSequenceNumber;
        [Persistent]
        public int UserSequenceNumber
        {
            get
            {
                return _userSequenceNumber;
            }
            set
            {
                SetPropertyValue("UserSequenceNumber", ref _userSequenceNumber, value);
            }
        }
        private int _homingBranch;
        [Persistent]
        public int HomingBranch
        {
            get
            {
                return _homingBranch;
            }
            set
            {
                SetPropertyValue("HomingBranch", ref _homingBranch, value);
            }
        }
        private string _homingAccountNumber;
        [Persistent]
        public string HomingAccountNumber
        {
            get
            {
                return _homingAccountNumber;
            }
            set
            {
                SetPropertyValue("HomingAccountNumber", ref _homingAccountNumber, value);
            }
        }
        private int _typeOfAccount;
        [Persistent]
        public int TypeOfAccount
        {
            get
            {
                return _typeOfAccount;
            }
            set
            {
                SetPropertyValue("TypeOfAccount", ref _typeOfAccount, value);
            }
        }
        private decimal? _amount;
        [Persistent]
        public decimal? Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                SetPropertyValue("Amount", ref _amount, value);
            }
        }
        private DateTime _actionDate;
        [Persistent]
        public DateTime ActionDate
        {
            get
            {
                return _actionDate;
            }
            set
            {
                SetPropertyValue("ActionDate", ref _actionDate, value);
            }
        }
        private int _entryClass;
        [Persistent]
        public int EntryClass
        {
            get
            {
                return _entryClass;
            }
            set
            {
                SetPropertyValue("EntryClass", ref _entryClass, value);
            }
        }
        private int _taxCode;
        [Persistent]
        public int TaxCode
        {
            get
            {
                return _taxCode;
            }
            set
            {
                SetPropertyValue("TaxCode", ref _taxCode, value);
            }
        }
        private string _userReference1;
        [Persistent]
        public string UserReference1
        {
            get
            {
                return _userReference1;
            }
            set
            {
                SetPropertyValue("UserReference1", ref _userReference1, value);
            }
        }
        private string _userReference2;
        [Persistent]
        public string UserReference2
        {
            get
            {
                return _userReference2;
            }
            set
            {
                SetPropertyValue("UserReference2", ref _userReference2, value);
            }
        }
        private string _homingAccountName;
        [Persistent]
        public string HomingAccountName
        {
            get
            {
                return _homingAccountName;
            }
            set
            {
                SetPropertyValue("HomingAccountName", ref _homingAccountName, value);
            }
        }
        private string _nonStandardHomingAccountNumber;
        [Persistent]
        public string NonStandardHomingAccountNumber
        {
            get
            {
                return _nonStandardHomingAccountNumber;
            }
            set
            {
                SetPropertyValue("NonStandardHomingAccountNumber", ref _nonStandardHomingAccountNumber, value);
            }
        }
        private int _homingInstitution;
        [Persistent]
        public int HomingInstitution
        {
            get
            {
                return _homingInstitution;
            }
            set
            {
                SetPropertyValue("HomingInstitution", ref _homingInstitution, value);
            }
        }

        private string _absaStatus;
        [Persistent]
        public string AbsaStatus
        {
            get
            {
                return _absaStatus;
            }
            set
            {
                SetPropertyValue("AbsaStatus", ref _absaStatus, value);
            }
        }

        private int _applicationId;
        [Persistent]
        public int ApplicationId
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

        private int _loanConsolidationDetailsId;
        [Persistent]
        public int LoanConsolidationDetailsId
        {
            get
            {
                return _loanConsolidationDetailsId;
            }
            set
            {
                SetPropertyValue("LoanConsolidationDetailsId", ref _loanConsolidationDetailsId, value);
            }
        }

        private int _refundId;
        [Persistent]
        public int RefundId
        {
            get
            {
                return _refundId;
            }
            set
            {
                SetPropertyValue("RefundId", ref _refundId, value);
            }
        }

        #region Constructors

        public ABSATransaction() : base() { }
        public ABSATransaction(Session session) : base(session) { }

        #endregion
    }
}
