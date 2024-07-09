using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.INS
{
    public sealed class INS_InsuranceClaim : XPLiteObject
    {

        private Int32 _ClaimNumber;
        [Key(AutoGenerate =true)]
        [Persistent]
        public Int32 ClaimNumber
        {
            get
            {
                return _ClaimNumber;
            }
            set
            {
                SetPropertyValue("ClaimNumber", ref _ClaimNumber, value);
            }
        }

        private Int32 _PolicyNumber;
        [Persistent]
        public Int32 PolicyNumber
        {
            get
            {
                return _PolicyNumber;
            }
            set
            {
                SetPropertyValue("PolicyNumber", ref _PolicyNumber, value);
            }
        }

        private decimal _ClaimAmount;
        [Persistent]
        public decimal ClaimAmount
        {
            get
            {
                return _ClaimAmount;
            }
            set
            {
                SetPropertyValue("ClaimAmount", ref _ClaimAmount, value);
            }
        }

        private int _ClaimBy;
        [Persistent]
        public int ClaimBy
        {
            get
            {
                return _ClaimBy;
            }
            set
            {
                SetPropertyValue("ClaimBy", ref _ClaimBy, value);
            }
        }

        private decimal _ClaimedPaidAmount;
        [Persistent]
        public decimal ClaimedPaidAmount
        {
            get
            {
                return _ClaimedPaidAmount;
            }
            set
            {
                SetPropertyValue("ClaimedPaidAmount", ref _ClaimedPaidAmount, value);
            }
        }

        private INS_ClaimReason _ClaimReasonId;
        [Persistent]
        public INS_ClaimReason ClaimReasonId
        {
            get
            {
                return _ClaimReasonId;
            }
            set
            {
                SetPropertyValue("ClaimReasonId", ref _ClaimReasonId, value);
            }
        }

        private DateTime? _EventDate;
        [Persistent]
        public DateTime? EventDate
        {
            get
            {
                return _EventDate;
            }
            set
            {
                SetPropertyValue("EventDate", ref _EventDate, value);
            }
        }

        private DateTime _NotificationDate;
        [Persistent]
        public DateTime NotificationDate
        {
            get
            {
                return _NotificationDate;
            }
            set
            {
                SetPropertyValue("NotificationDate", ref _NotificationDate, value);
            }
        }

        private INS_ClaimStatus _ClaimStatusId;
        [Persistent]
        public INS_ClaimStatus ClaimStatusId
        {
            get
            {
                return _ClaimStatusId;
            }
            set
            {
                SetPropertyValue("ClaimStatusId", ref _ClaimStatusId, value);
            }
        }

        private INS_ClaimRejectionReason _RejectionReasonId;
        [Persistent]
        public INS_ClaimRejectionReason RejectionReasonId
        {
            get
            {
                return _RejectionReasonId;
            }
            set
            {
                SetPropertyValue("RejectionReasonId", ref _RejectionReasonId, value);
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
                SetPropertyValue("CreatedDate", ref _CreatedDate, value);
            }
        }

        private DateTime _UpdatedDate;
        [Persistent]
        public DateTime UpdatedDate
        {
            get
            {
                return _UpdatedDate;
            }
            set
            {
                SetPropertyValue("UpdatedDate", ref _UpdatedDate, value);
            }
        }



        private Int64 _UpdatedBy;
        [Persistent]
        public Int64 UpdatedBy
        {
            get
            {
                return _UpdatedBy;
            }
            set
            {
                SetPropertyValue("UpdatedBy", ref _UpdatedBy, value);
            }
        }

        private Int64 _CreatedBy;
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

        private DateTime _ClaimStatusDate;
        [Persistent]
        public DateTime ClaimStatusDate
        {
            get
            {
                return _ClaimStatusDate;
            }
            set
            {
                SetPropertyValue("ClaimStatusDate", ref _ClaimStatusDate, value);
            }
        }

        private Int32 _RelationId;
        [Persistent]
        public Int32 RelationId
        {
            get
            {
                return _RelationId;
            }
            set
            {
                SetPropertyValue("RelationId", ref _RelationId, value);
            }
        }


        private Int32 _BeneficiaryTypeId;
        [Persistent]
        public Int32 BeneficiaryTypeId
        {
            get
            {
                return _BeneficiaryTypeId;
            }
            set
            {
                SetPropertyValue("BeneficiaryTypeId", ref _BeneficiaryTypeId, value);
            }
        }


        private string _EventDescripion;
        [Persistent]
        public string EventDescripion
        {
            get
            {
                return _EventDescripion;
            }
            set
            {
                SetPropertyValue("EventDescripion", ref _EventDescripion, value);
            }
        }


        private string _ClaimType;
        [Persistent]
        public string ClaimType
        {
            get
            {
                return _ClaimType;
            }
            set
            {
                SetPropertyValue("ClaimType", ref _ClaimType, value);
            }
        }

        private int _PaymentPeriod;
        [Persistent]
        public int PaymentPeriod
        {
            get
            {
                return _PaymentPeriod;
            }
            set
            {
                SetPropertyValue("PaymentPeriod", ref _PaymentPeriod, value);
            }
        }

        private string _Claimant;
        [Persistent]
        public string Claimant
        {
            get
            {
                return _Claimant;
            }
            set
            {
                SetPropertyValue("Claimant", ref _Claimant, value);
            }
        }


        private string _ClaimFor;
        [Persistent]
        public string ClaimFor
        {
            get
            {
                return _ClaimFor;
            }
            set
            {
                SetPropertyValue("ClaimFor", ref _ClaimFor, value);
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


        private Int64 _NextOfKinId;
        [Persistent]
        public Int64 NextOfKinId
        {
            get
            {
                return _NextOfKinId;
            }
            set
            {
                SetPropertyValue("NextOfKinId", ref _NextOfKinId, value);
            }
        }
        
        [Persistent]
        public int ProcessReasonId { get; set; }
       

        #region Constructors

        public INS_InsuranceClaim() : base() { }
        public INS_InsuranceClaim(Session session) : base(session) { }

        #endregion
    }
}
