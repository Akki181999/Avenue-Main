using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public sealed class ACC_BalanceTransfer : XPCustomObject
    {
        private Int64 _BalanceTransferId;
        [Key(AutoGenerate = true)]
        public Int64 BalanceTransferId
        {
            get
            {
                return _BalanceTransferId;
            }
            set
            {
                SetPropertyValue("BalanceTransferId", ref _BalanceTransferId, value);
            }
        }
        private Int64 _FromAccountId;
        [Persistent]
        public Int64 FromAccountId
        {
            get
            {
                return _FromAccountId;
            }
            set
            {
                SetPropertyValue("FromAccountId", ref _FromAccountId, value);
            }
        }
        private Int64 _ToAccountId;
        [Persistent]
        public Int64 ToAccountId
        {
            get
            {
                return _ToAccountId;
            }
            set
            {
                SetPropertyValue("ToAccountId", ref _ToAccountId, value);
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
        private int _PaymentModeId;
        public int PaymentModeId
        {
            get
            {
                return _PaymentModeId;
            }
            set
            {
                SetPropertyValue("PaymentModeId", ref _PaymentModeId, value);
            }
        }
        private Decimal _BalanceTransferAmount;
        [Persistent]
        public Decimal BalanceTransferAmount
        {
            get
            {
                return _BalanceTransferAmount;
            }
            set
            {
                SetPropertyValue("BalanceTransferAmount", ref _BalanceTransferAmount, value);
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

        private PER_Person _CreatedBy;
        [Persistent]
        public PER_Person CreatedBy
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


        private PER_Person _ProcessedBy;
        [Persistent]
        public PER_Person ProcessedBy
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
        #region Constructors

        public ACC_BalanceTransfer() : base() { }
        public ACC_BalanceTransfer(Session session) : base(session) { }

        #endregion
    }
}
