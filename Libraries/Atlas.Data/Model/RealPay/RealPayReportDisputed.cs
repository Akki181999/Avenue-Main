using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.RealPay
{
    public class RealPayReportDisputed: XPBaseObject
    {
        public struct ReportDisputedKey
        {
            [Persistent("TransactionId")]
            public string TransactionId;

            [Persistent("ContractRef"), Size(20)]
            public string ContractRef;

            [Persistent("ServiceType"), Size(20)]
            public string ServiceType;

            [Persistent("ValueDT")]
            public DateTime ValueDT;

            [Persistent("SuccessDT")]
            public DateTime SuccessDT;
        }
        public RealPayReportDisputed() : base() { }
        public RealPayReportDisputed(Session session) : base(session) { }

        [Persistent]
        public ReportDisputedKey ReportDisputed;

        private RealPayReportBatch _realpayReportBatch;
        [Persistent]
        [Indexed]
        public RealPayReportBatch ReportBatch
        {
            get
            {
                return _realpayReportBatch;
            }
            set
            {
                SetPropertyValue("ReportBatch", ref _realpayReportBatch, value);
            }
        }

        private DateTime _startDT;
        [Persistent]
        public DateTime StartDT
        {
            get
            {
                return _startDT;
            }
            set
            {
                SetPropertyValue("StartDT", ref _startDT, value);
            }
        }

        private string _contractNum;
        [Persistent, Size(20)]
        public string ContractNum
        {
            get
            {
                return _contractNum;
            }
            set
            {
                SetPropertyValue("ContractNum", ref _contractNum, value);
            }
        }

        private decimal _contractAmount;
        [Persistent]
        public decimal ContractAmount
        {
            get
            {
                return _contractAmount;
            }
            set
            {
                SetPropertyValue("ContractAmount", ref _contractAmount, value);
            }
        }

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
        [Persistent, Size(5)]
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

        private int _frequency;
        [Persistent]
        public int Frequency
        {
            get
            {
                return _frequency;
            }
            set
            {
                SetPropertyValue("Frequency", ref _frequency, value);
            }
        }

        private string _pan;
        [Persistent, Size(20)]
        public string Pan
        {
            get
            {
                return _pan;
            }
            set
            {
                SetPropertyValue("Pan", ref _pan, value);
            }
        }

        private string _terminalNum;
        [Persistent]
        public string TerminalNum
        {
            get
            {
                return _terminalNum;
            }
            set
            {
                SetPropertyValue("TerminalNum", ref _terminalNum, value);
            }
        }

        private string _cardAcceptor;
        [Persistent, Size(20)]
        public string CardAcceptor
        {
            get
            {
                return _cardAcceptor;
            }
            set
            {
                SetPropertyValue("CardAcceptor", ref _cardAcceptor, value);
            }
        }

        private string _institutionId;
        [Persistent, Size(5)]
        public string InstitutionId
        {
            get
            {
                return _institutionId;
            }
            set
            {
                SetPropertyValue("InstitutionId", ref _institutionId, value);
            }
        }

        private string _idNumber;
        [Persistent, Size(15)]
        public string IdNumber
        {
            get
            {
                return _idNumber;
            }
            set
            {
                SetPropertyValue("IdNumber", ref _idNumber, value);
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

        private string _RequestTransactionId;
        public string RequestTransactionId
        {
            get
            {
                return _RequestTransactionId;
            }
            set
            {
                SetPropertyValue("RequestTransactionId", ref _RequestTransactionId, value);
            }
        }
    }
}
