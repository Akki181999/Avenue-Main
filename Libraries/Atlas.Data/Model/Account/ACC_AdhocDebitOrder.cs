using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public class ACC_AdhocDebitOrder : XPLiteObject
    {
        private Int64 _debitOrderId;
        [Key(AutoGenerate = true)]
        public Int64 DebitOrderId
        {
            get
            {
                return _debitOrderId;
            }
            set
            {
                SetPropertyValue("DebitOrderId", ref _debitOrderId, value);
            }
        }

        private Int64 _AccountId;
        [Persistent]
        public Int64 AccountId
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

        private string _responseCode;
        [Persistent]
        public string responseCode
        {
            get
            {
                return _responseCode;
            }
            set
            {
                SetPropertyValue("responseCode", ref _responseCode, value);
            }
        }

        private string _pAN;
        [Persistent]
        public string pAN
        {
            get
            {
                return _pAN;
            }
            set
            {
                SetPropertyValue("pAN", ref _pAN, value);
            }
        }

        private string _transactionID;
        [Persistent]
        public string transactionID
        {
            get
            {
                return _transactionID;
            }
            set
            {
                SetPropertyValue("transactionID", ref _transactionID, value);
            }
        }

        private string _approvalCode;
        [Persistent]
        public string approvalCode
        {
            get
            {
                return _approvalCode;
            }
            set
            {
                SetPropertyValue("approvalCode", ref _approvalCode, value);
            }
        }

        private Decimal _contractAmount;
        [Persistent]
        public Decimal contractAmount
        {
            get
            {
                return _contractAmount;
            }
            set
            {
                SetPropertyValue("contractAmount", ref _contractAmount, value);
            }
        }

        private string _accountNumber;
        [Persistent]
        public string accountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                SetPropertyValue("accountNumber", ref _accountNumber, value);
            }
        }

        private string _accountType;
        [Persistent]
        public string accountType
        {
            get
            {
                return _accountType;
            }
            set
            {
                SetPropertyValue("accountType", ref _accountType, value);
            }
        }

        private string _tracking;
        [Persistent]
        public string tracking
        {
            get
            {
                return _tracking;
            }
            set
            {
                SetPropertyValue("tracking", ref _tracking, value);
            }
        }

        private string _adjRule;
        [Persistent]
        public string adjRule
        {
            get
            {
                return _adjRule;
            }
            set
            {
                SetPropertyValue("adjRule", ref _adjRule, value);
            }
        }

        private string _frequency;
        [Persistent]
        public string frequency
        {
            get
            {
                return _frequency;
            }
            set
            {
                SetPropertyValue("frequency", ref _frequency, value);
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
        private string _ContractNumber;
        [Persistent]
        public string ContractNumber
        {
            get
            {
                return _ContractNumber;
            }
            set
            {
                SetPropertyValue("ContractNumber", ref _ContractNumber, value);
            }
        }


        private bool _IsExist = true;
        [Persistent]
        public bool IsExist
        {
            get
            {
                return _IsExist;
            }
            set
            {
                SetPropertyValue("IsExist", ref _IsExist, value);
            }
        }

        private bool _IsCancel;
        [Persistent]
        public bool IsCancel
        {
            get
            {
                return _IsCancel;
            }
            set
            {
                SetPropertyValue("IsCancel", ref _IsCancel, value);
            }
        }

        private string _ServiceType;
        [Persistent]
        public string ServiceType
        {
            get
            {
                return _ServiceType;
            }
            set
            {
                SetPropertyValue("ServiceType", ref _ServiceType, value);
            }
        }

        private DateTime _CancelDate;
        [Persistent]
        public DateTime CancelDate
        {
            get
            {
                return _CancelDate;
            }
            set
            {
                SetPropertyValue("CancelDate", ref _CancelDate, value);
            }
        }

        private string _Request;
        [Persistent]
        public string Request
        {
            get
            {
                return _Request;
            }
            set
            {
                SetPropertyValue("Request", ref _Request, value);
            }
        }

        private string _Response;
        [Persistent]
        public string Response
        {
            get
            {
                return _Response;
            }
            set
            {
                SetPropertyValue("Response", ref _Response, value);
            }
        }

        private string _RequestTransactionId;
        [Persistent]
        public string RequestTransactionId
        {
            get
            {
                return _RequestTransactionId;
            }
            set
            {
                SetPropertyValue("RequestTransactionId", ref _RequestTransactionId, value);
            }
        }

        private string _ThirdPartyCancel;
        [Persistent]
        public string ThirdPartyCancel
        {
            get
            {
                return _ThirdPartyCancel;
            }
            set
            {
                SetPropertyValue("ThirdPartyCancel", ref _ThirdPartyCancel, value);
            }
        }

        [Persistent]
        public bool IsAdhoc { get; set; }

        #region Constructors

        public ACC_AdhocDebitOrder() : base() { }
        public ACC_AdhocDebitOrder(Session session) : base(session) { }

        #endregion
    }
}