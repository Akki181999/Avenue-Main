using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.DebiCheck
{
    public sealed class DebiCheckReportFailed: XPBaseObject
    {
        public struct ReportFailedKey
        {
            [Persistent("RequestTransactionId")]
            public string RequestTransactionId;

            [Persistent("ContractRef"), Size(20)]
            public string ContractRef;

            [Persistent("ServiceType"), Size(20)]
            public string ServiceType;

            [Persistent("ActionDT")]
            public DateTime ActionDT;

            [Persistent("CycleDT")]
            public DateTime CycleDT;
        }

        public DebiCheckReportFailed() : base() { }
        public DebiCheckReportFailed(Session session) : base(session) { }

        [Persistent]
        public ReportFailedKey ReportFailed;

        private DebiCheckReportBatch _ReportBatch;
        [Persistent]
        [Indexed]
        public DebiCheckReportBatch ReportBatch
        {
            get
            {
                return _ReportBatch;
            }
            set
            {
                SetPropertyValue("ReportBatch", ref _ReportBatch, value);
            }
        }

        private string _mandateID;
        [Persistent]
        public string MandateID
        {
            get
            {
                return _mandateID;
            }
            set
            {
                SetPropertyValue("MandateID", ref _mandateID, value);
            }
        }

        private string _mandateReference;
        [Persistent]
        public string MandateReference
        {
            get
            {
                return _mandateReference;
            }
            set
            {
                SetPropertyValue("MandateReference", ref _mandateReference, value);
            }
        }

        private string _contractReference;
        [Persistent]
        public string ContractReference
        {
            get
            {
                return _contractReference;
            }
            set
            {
                SetPropertyValue("ContractReference", ref _contractReference, value);
            }
        }

        private string _nationalId;
        [Persistent]
        public string NationalId
        {
            get
            {
                return _nationalId;
            }
            set
            {
                SetPropertyValue("NationalId", ref _nationalId, value);
            }
        }

        private string _debtorBank;
        [Persistent]
        public string DebtorBank
        {
            get
            {
                return _debtorBank;
            }
            set
            {
                SetPropertyValue("DebtorBank", ref _debtorBank, value);
            }
        }

        private DateTime _firstInstalmentDate;
        [Persistent]
        public DateTime FirstInstalmentDate
        {
            get
            {
                return _firstInstalmentDate;
            }
            set
            {
                SetPropertyValue("FirstInstalmentDate", ref _firstInstalmentDate, value);
            }
        }

        private DateTime _dateLoaded;
        [Persistent]
        public DateTime DateLoaded
        {
            get
            {
                return _dateLoaded;
            }
            set
            {
                SetPropertyValue("DateLoaded", ref _dateLoaded, value);
            }
        }


        [Persistent]
        public string CreditorBank { get; set; }

        private decimal _instalmentAmount;
        [Persistent]
        public decimal InstalmentAmount
        {
            get
            {
                return _instalmentAmount;
            }
            set
            {
                SetPropertyValue("InstalmentAmount", ref _instalmentAmount, value);
            }
        }


        [Persistent]
        public string ClientReference { get; set; }
        [Persistent]
        public string Status { get; set; }
        [Persistent]
        public string StatusDescription { get; set; }
        [Persistent]
        public DateTime DateCreated { get; set; }

        private int _instalmentNum;
        [Persistent]
        public int InstalmentNum
        {
            get
            {
                return _instalmentNum;
            }
            set
            {
                SetPropertyValue("InstalmentNum", ref _instalmentNum, value);
            }
        }

        private int _totalInstalments;
        [Persistent]
        public int TotalInstalments
        {
            get
            {
                return _totalInstalments;
            }
            set
            {
                SetPropertyValue("TotalInstalments", ref _totalInstalments, value);
            }
        }

        [Persistent]
        public string Disputable { get; set; }

        private string _employerCode;
        [Persistent, Size(20)]
        public string EmployerCode
        {
            get
            {
                return _employerCode;
            }
            set
            {
                SetPropertyValue("EmployerCode", ref _employerCode, value);
            }
        }

        private string _trackingIndicator;
        [Persistent]
        public string TrackingIndicator
        {
            get
            {
                return _trackingIndicator;
            }
            set
            {
                SetPropertyValue("TrackingIndicator", ref _trackingIndicator, value);
            }
        }

        private Boolean _IsProcessed;
        [Persistent]
        public Boolean IsProcessed
        {
            get
            {
                return _IsProcessed;
            }
            set
            {
                SetPropertyValue("IsProcessed", ref _IsProcessed, value);
            }
        }

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
    }
}
