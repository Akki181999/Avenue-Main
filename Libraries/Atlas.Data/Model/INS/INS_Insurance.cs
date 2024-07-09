using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.INS
{
    public sealed class INS_Insurance : XPCustomObject
    {
        private Int64 _PolicyNumber;
        [Key(AutoGenerate = true)]
        public Int64 PolicyNumber
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

        private Int32 _InsuranceTypeId;
        //[Persistent("InsuranceTypeId")]
        public Int32 InsuranceTypeId
        {
            get
            {
                return _InsuranceTypeId;
            }
            set
            {
                SetPropertyValue("InsuranceTypeId", ref _InsuranceTypeId, value);
            }
        }
        
       
        private Int32 _ClientId;
        public Int32 ClientId
        {
            get
            {
                return _ClientId;
            }
            set
            {
                SetPropertyValue("ClientId", ref _ClientId, value);
            }
        }
        
        private Int64 _AccountId;
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
      
        private decimal _TotalCoverageAmount;
        public decimal TotalCoverageAmount
        {
            get
            {
                return _TotalCoverageAmount;
            }
            set
            {
                SetPropertyValue("TotalCoverageAmount", ref _TotalCoverageAmount, value);
            }
        }
       
        private string _PolicyStatus;
        public string PolicyStatus
        {
            get
            {
                return _PolicyStatus;
            }
            set
            {
                SetPropertyValue("PolicyStatus", ref _PolicyStatus, value);
            }
        }
       
        private DateTime _PolicyStatusDate;
        public DateTime PolicyStatusDate
        {
            get
            {
                return _PolicyStatusDate;
            }
            set
            {
                SetPropertyValue("PolicyStatusDate", ref _PolicyStatusDate, value);
            }
        }
       
        private DateTime _CreatedDate;
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
       
        private Int64 _CreatedBy;
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
       
        private DateTime _UpdatedDate;
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
       
        private DateTime _PolicyReportedDate;
        public DateTime PolicyReportedDate
        {
            get
            {
                return _PolicyReportedDate;
            }
            set
            {
                SetPropertyValue("PolicyReportedDate", ref _PolicyReportedDate, value);
            }
        }
        private Int64? _VAPAccountId;
        public Int64? VAPAccountId
        {
            get
            {
                return _VAPAccountId;
            }
            set
            {
                SetPropertyValue("VAPAccountId", ref _VAPAccountId, value);
            }
        }

        #region Constructors

        public INS_Insurance() : base() { }
        public INS_Insurance(Session session) : base(session) { }

        #endregion
    }
}
