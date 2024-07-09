using Atlas.Domain.Model.Account;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public sealed class DisputedRepayment : XPCustomObject
    {
        private Int64 _DisputedRepaymentId;
        [Key(AutoGenerate = true)]
        public Int64 DisputedRepaymentId
        {
            get
            {
                return _DisputedRepaymentId;
            }
            set
            {
                SetPropertyValue("DisputedRepaymentId", ref _DisputedRepaymentId, value);
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
        private string _TransactionId;
        [Persistent]
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
       

       
        private Int32 _InstallmentNo;
        [Persistent]
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
        private Int64 _RepaymentId;
        [Persistent]
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

        private Int64 _RefundId;
        [Persistent]
        public Int64 RefundId
        {
            get
            {
                return _RefundId;
            }
            set
            {
                SetPropertyValue("RefundId", ref _RefundId, value);
            }
        }
        private Decimal _DisputedAmount;
        [Persistent]
        public Decimal DisputedAmount
        {
            get
            {
                return _DisputedAmount;
            }
            set
            {
                SetPropertyValue("DisputedAmount", ref _DisputedAmount, value);
            }
        }
        private int _StatusId;
        [Persistent]
        public int StatusId
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

        private Int32 _CreatedBy;
        [Persistent]
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
        [Persistent]
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

        private Boolean _IsManual;
        public Boolean IsManual
        {
            get
            {
                return _IsManual;
            }
            set
            {
                SetPropertyValue("IsManual", ref _IsManual, value);
            }
        }

        private DateTime? _ProcessedOn;
        [Persistent]
        public DateTime? ProcessedOn
        {
            get
            {
                return _ProcessedOn;
            }
            set
            {
                SetPropertyValue("ProcessedOn", ref _ProcessedOn, value);
            }
        }


        private Int32 _ProcessedBy;
        [Persistent]
        public Int32 ProcessedBy
        {
            get
            {
                return _ProcessedBy;
            }
            set
            {
                SetPropertyValue("ProcessedBy", ref _ProcessedBy, value);
            }
        }
        [Persistent]
        public DateTime DisputedDate { get; set; }
        [Persistent]
        public Boolean IsAutoProcess { get; set; }
        #region Constructors

        public DisputedRepayment() : base() { }
        public DisputedRepayment(Session session) : base(session) { }

        #endregion
    }
}
