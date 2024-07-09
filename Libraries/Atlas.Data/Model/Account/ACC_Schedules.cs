using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public sealed class ACC_Schedules : XPLiteObject
    {
        private Int32? _AccountId;     
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

        private Int32? _Installment_SrNo;
      
        public Int32? Installment_SrNo
        {
            get
            {
                return _Installment_SrNo;
            }
            set
            {
                SetPropertyValue("Installment_SrNo", ref _Installment_SrNo, value);
            }
        }

        private Int32? _Noofdays;
       
        public Int32? Noofdays
        {
            get
            {
                return _Noofdays;
            }
            set
            {
                SetPropertyValue("Noofdays", ref _Noofdays, value);
            }
        }

        private Decimal? _DeferredAmount;
       
        public Decimal? DeferredAmount
        {
            get
            {
                return _DeferredAmount;
            }
            set
            {
                SetPropertyValue("DeferredAmount", ref _DeferredAmount, value);
            }
        }

        private Decimal? _Interest;
       
        public Decimal? Interest
        {
            get
            {
                return _Interest;
            }
            set
            {
                SetPropertyValue("Interest", ref _Interest, value);
            }
        }

        private Decimal? _Servicefee;
       
        public Decimal? Servicefee
        {
            get
            {
                return _Servicefee;
            }
            set
            {
                SetPropertyValue("Servicefee", ref _Servicefee, value);
            }
        }

        private Decimal? _Premium;
        
        public Decimal? Premium
        {
            get
            {
                return _Premium;
            }
            set
            {
                SetPropertyValue("Premium", ref _Premium, value);
            }
        }

        private Decimal? _Installment;
       
        public Decimal? Installment
        {
            get
            {
                return _Installment;
            }
            set
            {
                SetPropertyValue("Installment", ref _Installment, value);
            }
        }

        private Decimal? _Totalinstallment;
      
        public Decimal? Totalinstallment
        {
            get
            {
                return _Totalinstallment;
            }
            set
            {
                SetPropertyValue("Totalinstallment", ref _Totalinstallment, value);
            }
        }

        private Decimal? _Remaningbalance;
        
        public Decimal? Remaningbalance
        {
            get
            {
                return _Remaningbalance;
            }
            set
            {
                SetPropertyValue("Remaningbalance", ref _Remaningbalance, value);
            }
        }

        private DateTime? _Duedate;
       
        public DateTime? Duedate
        {
            get
            {
                return _Duedate;
            }
            set
            {
                SetPropertyValue("Duedate", ref _Duedate, value);
            }
        }

        private Decimal? _VAP;
        
        public Decimal? VAP
        {
            get
            {
                return _VAP;
            }
            set
            {
                SetPropertyValue("VAP", ref _VAP, value);
            }
        }

        private Decimal? _Paid_Installment;
       
        public Decimal? Paid_Installment
        {
            get
            {
                return _Paid_Installment;
            }
            set
            {
                SetPropertyValue("Paid_Installment", ref _Paid_Installment, value);
            }
        }

        private Int64 _ACC_ScheduleId;
        [Key(AutoGenerate = true)]
        public Int64 ACC_ScheduleId
        {
            get
            {
                return _ACC_ScheduleId;
            }
            set
            {
                SetPropertyValue("ACC_ScheduleId", ref _ACC_ScheduleId, value);
            }
        }
        private Decimal? _VAP_Funeral;

        public Decimal? VAP_Funeral
        {
            get
            {
                return _VAP_Funeral;
            }
            set
            {
                SetPropertyValue("VAP_Funeral", ref _VAP_Funeral, value);
            }
        }
        private Decimal? _VAP_Tax;

        public Decimal? VAP_Tax
        {
            get
            {
                return _VAP_Tax;
            }
            set
            {
                SetPropertyValue("VAP_Tax", ref _VAP_Tax, value);
            }
        }
        private Decimal? _VAP_Other;

        public Decimal? VAP_Other
        {
            get
            {
                return _VAP_Other;
            }
            set
            {
                SetPropertyValue("VAP_Other", ref _VAP_Other, value);
            }
        }


        private DateTime? _paidDate;
        [Persistent]
        public DateTime? PaidDate
        {
            get
            {
                return _paidDate;
            }
            set
            {
                SetPropertyValue("PaidDate", ref _paidDate, value);
            }
        }

        private PaymentModes.PaymentModes _PaymentModeId;
        public PaymentModes.PaymentModes PaymentModeId
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
        private Decimal? _ServiceVATAmount;
        public Decimal? ServiceVATAmount
        {
            get
            {
                return _ServiceVATAmount;
            }
            set
            {
                SetPropertyValue("ServiceVATAmount", ref _ServiceVATAmount, value);
            }
        }
        private Decimal? _InitiationFeeAmount;
        public Decimal? InitiationFeeAmount
        {
            get
            {
                return _InitiationFeeAmount;
            }
            set
            {
                SetPropertyValue("InitiationFeeAmount", ref _InitiationFeeAmount, value);
            }
        }
        private Decimal? _InitiationVATAmount;
        public Decimal? InitiationVATAmount
        {
            get
            {
                return _InitiationVATAmount;
            }
            set
            {
                SetPropertyValue("InitiationFeeAmount", ref _InitiationVATAmount, value);
            }
        }
        private String _DebitOrderStatus;
        public String DebitOrderStatus
        {
            get
            {
                return _DebitOrderStatus;
            }
            set
            {
                SetPropertyValue("DebitOrderStatus", ref _DebitOrderStatus, value);
            }
        }

        private String _AutoRepaymentStatus;
        public String AutoRepaymentStatus
        {
            get
            {
                return _AutoRepaymentStatus;
            }
            set
            {
                SetPropertyValue("AutoRepaymentStatus", ref _AutoRepaymentStatus, value);
            }
        }

        private String _StatusDescription;
        public String StatusDescription
        {
            get
            {
                return _StatusDescription;
            }
            set
            {
                SetPropertyValue("StatusDescription", ref _StatusDescription, value);
            }
        }
        [Persistent]
        public Boolean IsAdhoc
        {
            get;set;
        }

        #region Constructors

        public ACC_Schedules() : base() 
        {
            DebitOrderStatus = "CREATED";
        }
        public ACC_Schedules(Session session) : base(session) 
        {
            DebitOrderStatus = "CREATED";
        }

        #endregion
    }
}
