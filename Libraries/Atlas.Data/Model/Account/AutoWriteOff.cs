using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.Account
{
    public class AutoWriteOff : XPLiteObject
    {
        private Int64 _autoWriteOffId;
        [Key(AutoGenerate = true)]
        public Int64 AutoWriteOffId
        {
            get
            {
                return _autoWriteOffId;
            }
            set
            {
                SetPropertyValue("AutoWriteOffId", ref _autoWriteOffId, value);
            }
        }

        private DateTime _fromDate;
        [Persistent]
        public DateTime FromDate
        {
            get
            {
                return _fromDate;
            }
            set
            {
                SetPropertyValue("FromDate", ref _fromDate, value);
            }
        }

        private DateTime _toDate;
        [Persistent]
        public DateTime ToDate
        {
            get
            {
                return _toDate;
            }
            set
            {
                SetPropertyValue("ToDate", ref _toDate, value);
            }
        }

        private Decimal _fromAmount;
        public Decimal FromAmount
        {
            get
            {
                return _fromAmount;
            }
            set
            {
                SetPropertyValue("FromAmount", ref _fromAmount, value);
            }
        }

        private Decimal _toAmount;
        public Decimal ToAmount
        {
            get
            {
                return _toAmount;
            }
            set
            {
                SetPropertyValue("ToAmount", ref _toAmount, value);
            }
        }

        private int _accountStatus;
        public int AccountStatus
        {
            get
            {
                return _accountStatus;
            }
            set
            {
                SetPropertyValue("AccountStatus", ref _accountStatus, value);
            }
        }

        private int _transactionTypeId;
        public int TransactionTypeId
        {
            get
            {
                return _transactionTypeId;
            }
            set
            {
                SetPropertyValue("TransactionTypeId", ref _transactionTypeId, value);
            }
        }

        private int _transactionTypeGroupId;
        public int TransactionTypeGroupId
        {
            get
            {
                return _transactionTypeGroupId;
            }
            set
            {
                SetPropertyValue("TransactionTypeGroupId", ref _transactionTypeGroupId, value);
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

        private string _status;
        public string Status
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

        private bool _executeDaily;
        public bool ExecuteDaily
        {
            get
            {
                return _executeDaily;
            }
            set
            {
                SetPropertyValue("ExecuteDaily", ref _executeDaily, value);
            }
        }

        #region Constructors
        public AutoWriteOff() : base() { }
        public AutoWriteOff(Session session) : base(session) { }
        #endregion

    }
}
