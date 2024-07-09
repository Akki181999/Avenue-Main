using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.MicroFinance
{
   
        public class MicroFinance : XPLiteObject
        {
            private long _MicroFinanceId;
            [Key(AutoGenerate = true)]
            [Persistent]
            public long MicroFinanceId
            {
                get
                {
                    return _MicroFinanceId;
                }
                set
                {
                    _MicroFinanceId = value;
                }
            }

            private string _CompanyName;
            [Persistent]
            public string CompanyName
            {
                get
                {
                    return _CompanyName;
                }
                set
                {
                    _CompanyName = value;
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
                    _CreatedDate = value;
                }
            }
            private int _ApprovedBy;
            [Persistent]
            public int ApprovedBy
            {
                get
                {
                    return _ApprovedBy;
                }
                set
                {
                    _ApprovedBy = value;
                }
            }
            private DateTime _ApprovedDate;
            [Persistent]
            public DateTime ApprovedDate
            {
                get
                {
                    return _ApprovedDate;
                }
                set
                {
                    _ApprovedDate = value;
                }
            }
            private Int32 _BankCode;
            [Persistent]
            public Int32 BankCode
            {
                get
                {
                    return _BankCode;
                }
                set
                {
                    _BankCode = value;
                }
            }
            private string _AccountNo;
            [Persistent]
            public string AccountNo
            {
                get
                {
                    return _AccountNo;
                }
                set
                {
                    _AccountNo = value;
                }
            }
        private string _VerifiedName;
        [Persistent]
        public string VerifiedName
        {
            get
            {
                return _VerifiedName;
            }
            set
            {
                _VerifiedName = value;
            }
        }
        private string _VerifiedIDNumber;
        [Persistent]
        public string VerifiedIDNumber
        {
            get
            {
                return _VerifiedIDNumber;
            }
            set
            {
                _VerifiedIDNumber = value;
            }
        }
        private int _Status;
            [Persistent]
            public int Status
            {
                get
                {
                    return _Status;
                }
                set
                {
                    _Status = value;
                }
            }
        private int _accountType;
        [Persistent]
        public int AccountType
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
        private string _TradingName;
        [Persistent]
        public string TradingName
        {
            get
            {
                return _TradingName;
            }
            set
            {
                _TradingName = value;
            }
        }
        private string _DisbursementType;
        [Persistent]
        public string DisbursementType
        {
            get
            {
                return _DisbursementType;
            }
            set
            {
                _DisbursementType = value;
            }
        }
        public MicroFinance() : base() { }
        public MicroFinance(Session session) : base(session) { }
    }
    }