using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Account
{
    public class ACC_AdhocPaymentPlan : XPLiteObject
    {
        private Int64 _PaymentPlanId;
        [Key(AutoGenerate = true)]
        public Int64 PaymentPlanId
        {
            get
            {
                return _PaymentPlanId;
            }
            set
            {
                SetPropertyValue("PaymentPlanId", ref _PaymentPlanId, value);
            }
        }

        private Int32? _InstallmentNumber;
        [Persistent]
        public Int32? InstallmentNumber
        {
            get
            {
                return _InstallmentNumber;
            }
            set
            {
                SetPropertyValue("InstallmentNumber", ref _InstallmentNumber, value);
            }
        }
        private Int32? _AccountId;
        [Persistent]
        public Int32? AccountId
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

        private Decimal _InstallmentAmount;
        [Persistent]
        public Decimal InstallmentAmount
        {
            get
            {
                return _InstallmentAmount;
            }
            set
            {
                SetPropertyValue("InstallmentAmount", ref _InstallmentAmount, value);
            }
        }

        private Decimal _RemainingBalance;
        [Persistent]
        public Decimal RemainingBalance
        {
            get
            {
                return _RemainingBalance;
            }
            set
            {
                SetPropertyValue("RemainingBalance", ref _RemainingBalance, value);
            }
        }

        private DateTime _DueDate;
        [Persistent]
        public DateTime DueDate
        {
            get
            {
                return _DueDate;
            }
            set
            {
                SetPropertyValue("DueDate", ref _DueDate, value);
            }
        }

        private Decimal _PaidInstallment;
        [Persistent]
        public Decimal PaidInstallment
        {
            get
            {
                return _PaidInstallment;
            }
            set
            {
                SetPropertyValue("PaidInstallment", ref _PaidInstallment, value);
            }
        }

        private DateTime _PaidDate;
        [Persistent]
        public DateTime PaidDate
        {
            get
            {
                return _PaidDate;
            }
            set
            {
                SetPropertyValue("PaidDate", ref _PaidDate, value);
            }
        }

        private DateTime _CreateDate;
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

        private int _FrequencyTypeId;
        [Persistent]
        public int FrequencyTypeId
        {
            get
            {
                return _FrequencyTypeId;
            }
            set
            {
                SetPropertyValue("FrequencyTypeId", ref _FrequencyTypeId, value);
            }
        }

        private string _PayDay;
        [Persistent]
        public string PayDay
        {
            get
            {
                return _PayDay;
            }
            set
            {
                SetPropertyValue("PayDay", ref _PayDay, value);
            }
        }


        public ACC_AdhocPaymentPlan() : base() { }
        public ACC_AdhocPaymentPlan(Session session) : base(session) { }

    }
}
