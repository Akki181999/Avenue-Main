using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public class LoanConsolidationDetails : XPLiteObject
    {
        private Int64 _LoanConsolidationDetailsId;
        [Key(AutoGenerate = true)]
        public Int64 LoanConsolidationDetailsId
        {
            get
            {
                return _LoanConsolidationDetailsId;
            }
            set
            {
                SetPropertyValue("LoanConsolidationDetailsId", ref _LoanConsolidationDetailsId, value);
            }
        }

        private Int64 _ApplicationId;
        [Indexed]
        [Persistent]
        public Int64 ApplicationId
        {
            get
            {
                return _ApplicationId;
            }
            set
            {
                SetPropertyValue("ApplicationId", ref _ApplicationId, value);
            }
        }
        private Int64 _MicroFinanceId;
        [Indexed]
        [Persistent]
        public Int64 MicroFinanceId
        {
            get
            {
                return _MicroFinanceId;
            }
            set
            {
                SetPropertyValue("MicroFinanceId", ref _MicroFinanceId, value);
            }
        }
        private string _ReferenceNumber;
        [Indexed]
        [Persistent]
        public string ReferenceNumber
        {
            get
            {
                return _ReferenceNumber;
            }
            set
            {
                SetPropertyValue("ReferenceNumber", ref _ReferenceNumber, value);
            }
        }
        private DateTime _CreateDate;
        [Indexed]
        [Persistent]
        public DateTime CreateDate
        {
            get
            {
                return _CreateDate;
            }
            set
            {
                SetPropertyValue("CreateDate", ref _CreateDate, value);
            }
        }
        private Int64 _CreatedBy;
        [Indexed]
        [Persistent]
        public Int64 CreatedBy
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
        private DateTime _ExpiryDate;
        [Indexed]
        [Persistent]
        public DateTime ExpiryDate
        {
            get
            {
                return _ExpiryDate;
            }
            set
            {
                SetPropertyValue("ExpiryDate", ref _ExpiryDate, value);
            }
        }
        private DateTime _NextDebitOrderDate;
        [Indexed]
        [Persistent]
        public DateTime NextDebitOrderDate
        {
            get
            {
                return _NextDebitOrderDate;
            }
            set
            {
                SetPropertyValue("NextDebitOrderDate", ref _NextDebitOrderDate, value);
            }
        }
        private DateTime _VerifiedDate;
        [Indexed]
        [Persistent]
        public DateTime VerifiedDate
        {
            get
            {
                return _VerifiedDate;
            }
            set
            {
                SetPropertyValue("VerifiedDate", ref _VerifiedDate, value);
            }
        }
        private Int64 _VerifiedBy;
        [Indexed]
        [Persistent]
        public Int64 VerifiedBy
        {
            get
            {
                return _VerifiedBy;
            }
            set
            {
                SetPropertyValue("VerifiedBy", ref _VerifiedBy, value);
            }
        }
        private int _Status;
        [Indexed]
        [Persistent]
        public int Status
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
        private decimal _SettlementAmount;
        [Indexed]
        [Persistent]
        public decimal SettlementAmount
        {
            get
            {
                return _SettlementAmount;
            }
            set
            {
                SetPropertyValue("SettlementAmount", ref _SettlementAmount, value);
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
                SetPropertyValue("DisbursementType", ref _DisbursementType, value);
            }
        }
        public LoanConsolidationDetails() : base() { }
        public LoanConsolidationDetails(Session session) : base(session) { }
    }
}
