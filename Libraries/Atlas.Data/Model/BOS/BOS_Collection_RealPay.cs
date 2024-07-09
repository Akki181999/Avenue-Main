using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{

    public sealed class BOS_Collection_RealPay : XPCustomObject
    {

        private Int64 _CollectionId;
        [Key(AutoGenerate = true)]
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

        private string _ProductCode;
        public string ProductCode
        {
            get
            {
                return _ProductCode;
            }
            set
            {
                SetPropertyValue("ProductCode", ref _ProductCode, value);
            }
        }

        private DateTime? _TransactionDate;
        public DateTime? TransactionDate
        {
            get
            {
                return _TransactionDate;
            }
            set
            {
                SetPropertyValue("TransactionDate", ref _TransactionDate, value);
            }
        }

        private DateTime? _TrackingStartDate;
        public DateTime? TrackingStartDate
        {
            get
            {
                return _TrackingStartDate;
            }
            set
            {
                SetPropertyValue("TrackingStartDate", ref _TrackingStartDate, value);
            }
        }

        private char _Status;
        public char Status
        {
            get
            {
                return _Status;
            }
            set
            {
                SetPropertyValue("Status", ref _Status, value);
            }
        }

        private string _ContractNumber;
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

        private string _MerchantNumber;
        public string MerchantNumber
        {
            get
            {
                return _MerchantNumber;
            }
            set
            {
                SetPropertyValue("MerchantNumber", ref _MerchantNumber, value);
            }
        }

        private decimal? _AmountRequested;
        public decimal? AmountRequested
        {
            get
            {
                return _AmountRequested;
            }
            set
            {
                SetPropertyValue("AmountRequested", ref _AmountRequested, value);
            }
        }

        private int _InstallmentSequence;
        public int InstallmentSequence
        {
            get
            {
                return _InstallmentSequence;
            }
            set
            {
                SetPropertyValue("InstallmentSequence", ref _InstallmentSequence, value);
            }
        }

        private decimal? _BankStatementRef;
        public decimal? BankStatementRef
        {
            get
            {
                return _BankStatementRef;
            }
            set
            {
                SetPropertyValue("BankStatementRef", ref _BankStatementRef, value);
            }
        }

        private decimal? _Total;
        public decimal? Total
        {
            get
            {
                return _Total;
            }
            set
            {
                SetPropertyValue("Total", ref _Total, value);
            }
        }

        private string _ClientNumber;
        public string ClientNumber
        {
            get
            {
                return _ClientNumber;
            }
            set
            {
                SetPropertyValue("ClientNumber", ref _ClientNumber, value);
            }
        }

        private string _ContractSequence;
        public string ContractSequence
        {
            get
            {
                return _ContractSequence;
            }
            set
            {
                SetPropertyValue("ContractSequence", ref _ContractSequence, value);
            }
        }

        private decimal _AmountCollected;
        public decimal AmountCollected
        {
            get
            {
                return _AmountCollected;
            }
            set
            {
                SetPropertyValue("AmountCollected", ref _AmountCollected, value);
            }
        }

        private string _Result;
        public string Result
        {
            get
            {
                return _Result;
            }
            set
            {
                SetPropertyValue("Result", ref _Result, value);
            }
        }

        private string _TrackingHits;
        public string TrackingHits
        {
            get
            {
                return _TrackingHits;
            }
            set
            {
                SetPropertyValue("TrackingHits", ref _TrackingHits, value);
            }
        }

        private string _ErrorMsg;
        public string ErrorMsg
        {
            get
            {
                return _ErrorMsg;
            }
            set
            {
                SetPropertyValue("ErrorMsg", ref _ErrorMsg, value);
            }
        }

        private Boolean _ProcessStatus;
        public Boolean ProcessStatus
        {
            get
            {
                return _ProcessStatus;
            }
            set
            {
                SetPropertyValue("ProcessStatus", ref _ProcessStatus, value);
            }
        }

        #region Constructors

        public BOS_Collection_RealPay() : base() { }
        public BOS_Collection_RealPay(Session session) : base(session) { }

        #endregion
    }
}
