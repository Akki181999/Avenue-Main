using Atlas.Domain.Model.Account;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public class EarlySettlementOffer : XPLiteObject
    {
        private Int64 _earlySettlementOfferId;
        [Key(AutoGenerate = true)]
        public Int64 EarlySettlementOfferId
        {
            get
            {
                return _earlySettlementOfferId;
            }
            set
            {
                SetPropertyValue("EarlySettlementOfferId", ref _earlySettlementOfferId, value);
            }
        }

        private Int64 _accountId;
        [Persistent("AccountId")]
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

        private DateTime _offerDate;
        [Persistent]
        public DateTime OfferDate
        {
            get
            {
                return _offerDate;
            }
            set
            {
                SetPropertyValue("OfferDate", ref _offerDate, value);
            }
        }

        private DateTime _expiryDate;
        [Persistent]
        public DateTime ExpiryDate
        {
            get
            {
                return _expiryDate;
            }
            set
            {
                SetPropertyValue("ExpiryDate", ref _expiryDate, value);
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

        private DateTime _lastUpdatedOn;
        [Persistent]
        public DateTime LastUpdatedOn
        {
            get
            {
                return _lastUpdatedOn;
            }
            set
            {
                SetPropertyValue("LastUpdatedOn", ref _lastUpdatedOn, value);
            }
        }

        private Int64 _repaymentId;
        public Int64 RepaymentId
        {
            get
            {
                return _repaymentId;
            }
            set
            {
                SetPropertyValue("RepaymentId", ref _repaymentId, value);
            }
        }

        private Decimal _vAPPayableAmount;
        public Decimal VAPPayableAmount
        {
            get
            {
                return _vAPPayableAmount;
            }
            set
            {
                SetPropertyValue("VAPPayableAmount", ref _vAPPayableAmount, value);
            }
        }

        private Decimal _loanPayableAmount;
        public Decimal LoanPayableAmount
        {
            get
            {
                return _loanPayableAmount;
            }
            set
            {
                SetPropertyValue("LoanPayableAmount", ref _loanPayableAmount, value);
            }
        }

        private Decimal _totalPayableAmount;
        public Decimal TotalPayableAmount
        {
            get
            {
                return _totalPayableAmount;
            }
            set
            {
                SetPropertyValue("TotalPayableAmount", ref _totalPayableAmount, value);
            }
        }

        #region Constructors
        public EarlySettlementOffer() : base() { }
        public EarlySettlementOffer(Session session) : base(session) { }
        #endregion
    }


    public class EarlySettlementOfferDetails : XPLiteObject
    {
        private Int64 _earlySettlementOfferDetailsId;
        [Key(AutoGenerate = true)]
        public Int64 EarlySettlementOfferDetailsId
        {
            get
            {
                return _earlySettlementOfferDetailsId;
            }
            set
            {
                SetPropertyValue("EarlySettlementOfferDetailsId", ref _earlySettlementOfferDetailsId, value);
            }
        }

        private String _description;
        public String Description
        {
            get
            {
                return _description;
            }
            set
            {
                SetPropertyValue("Description", ref _description, value);
            }
        }

        private Int64 _earlySettlementOfferId;
        public Int64 EarlySettlementOfferId
        {
            get
            {
                return _earlySettlementOfferId;
            }
            set
            {
                SetPropertyValue("EarlySettlementOfferId", ref _earlySettlementOfferId, value);
            }
        }

        private DateTime? _startDate;
        [Persistent]
        public DateTime? StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                SetPropertyValue("StartDate", ref _startDate, value);
            }
        }

        private DateTime? _endDate;
        [Persistent]
        public DateTime? EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                SetPropertyValue("EndDate", ref _endDate, value);
            }
        }

        private Int64? _durationInDays;
        public Int64? DurationInDays
        {
            get
            {
                return _durationInDays;
            }
            set
            {
                SetPropertyValue("DurationInDays", ref _durationInDays, value);
            }
        }

        private Int64 _noOfInstalments;
        public Int64 NoOfInstalments
        {
            get
            {
                return _noOfInstalments;
            }
            set
            {
                SetPropertyValue("NoOfInstalments", ref _noOfInstalments, value);
            }
        }

        private Decimal _repay;
        public Decimal Repay
        {
            get
            {
                return _noOfInstalments;
            }
            set
            {
                SetPropertyValue("Repay", ref _repay, value);
            }
        }

        private Decimal _capital;
        public Decimal Capital
        {
            get
            {
                return _capital;
            }
            set
            {
                SetPropertyValue("Capital", ref _capital, value);
            }
        }

        private Decimal _interest;
        public Decimal Interest
        {
            get
            {
                return _interest;
            }
            set
            {
                SetPropertyValue("Interest", ref _interest, value);
            }
        }

        private Decimal _initFee;
        public Decimal InitFee
        {
            get
            {
                return _initFee;
            }
            set
            {
                SetPropertyValue("InitFee", ref _initFee, value);
            }
        }

        private Decimal _servFee;
        public Decimal ServFee
        {
            get
            {
                return _servFee;
            }
            set
            {
                SetPropertyValue("ServFee", ref _servFee, value);
            }
        }

        private Decimal _premium;
        public Decimal Premium
        {
            get
            {
                return _premium;
            }
            set
            {
                SetPropertyValue("Premium", ref _premium, value);
            }
        }

        private Decimal _vAT;
        public Decimal VAT
        {
            get
            {
                return _vAT;
            }
            set
            {
                SetPropertyValue("VAT", ref _vAT, value);
            }
        }

        private Decimal _vAPAmount;
        public Decimal VAPAmount
        {
            get
            {
                return _vAPAmount;
            }
            set
            {
                SetPropertyValue("VAPAmount", ref _vAPAmount, value);
            }
        }


        #region Constructors
        public EarlySettlementOfferDetails() : base() { }
        public EarlySettlementOfferDetails(Session session) : base(session) { }
        #endregion
    }
}
