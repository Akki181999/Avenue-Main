using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Atlas.Domain.Model.ABSA
{
    public class ABSATrailer : XPLiteObject
    {
        private int _trailerId;

        [Persistent]
        [Key(AutoGenerate = true)]
        public int TrailerId
        {
            get
            {
                return _trailerId;
            }
            set
            {
                SetPropertyValue("TrailerId", ref _trailerId, value);
            }
        }
        private int _transmissionNumber;
        [Persistent]
        public int TransmissionNumber
        {
            get
            {
                return _transmissionNumber;
            }
            set
            {
                SetPropertyValue("TransmissionNumber", ref _transmissionNumber, value);
            }
        }
        private string _recordIdentifier;
        [Persistent]
        public string RecordIdentifier
        {
            get
            {
                return _recordIdentifier;
            }
            set
            {
                SetPropertyValue("RecordIdentifier", ref _recordIdentifier, value);
            }
        }
        private string _dataSetStatus;
        [Persistent]
        public string DataSetStatus
        {
            get
            {
                return _dataSetStatus;
            }
            set
            {
                SetPropertyValue("DataSetStatus", ref _dataSetStatus, value);
            }
        }
        private string _bankservRecordIdentifier;
        [Persistent]
        public string BankservRecordIdentifier
        {
            get
            {
                return _bankservRecordIdentifier;
            }
            set
            {
                SetPropertyValue("BankservRecordIdentifier", ref _bankservRecordIdentifier, value);
            }
        }
        private string _bankservUserCode;
        [Persistent]
        public string BankservUserCode
        {
            get
            {
                return _bankservUserCode;
            }
            set
            {
                SetPropertyValue("BankservUserCode", ref _bankservUserCode, value);
            }
        }
        private int _firstSequenceNumber;
        [Persistent]
        public int FirstSequenceNumber
        {
            get
            {
                return _firstSequenceNumber;
            }
            set
            {
                SetPropertyValue("FirstSequenceNumber", ref _firstSequenceNumber, value);
            }
        }
        private int _lastSequenceNumber;
        [Persistent]
        public int LastSequenceNumber
        {
            get
            {
                return _lastSequenceNumber;
            }
            set
            {
                SetPropertyValue("LastSequenceNumber", ref _lastSequenceNumber, value);
            }
        }
        private DateTime _firstActionDate;
        [Persistent]
        public DateTime FirstActionDate
        {
            get
            {
                return _firstActionDate;
            }
            set
            {
                SetPropertyValue("FirstActionDate", ref _firstActionDate, value);
            }
        }
        private DateTime _lastActionDate;
        [Persistent]
        public DateTime LastActionDate
        {
            get
            {
                return _lastActionDate;
            }
            set
            {
                SetPropertyValue("LastActionDate", ref _lastActionDate, value);
            }
        }
        private int _noOfDebitRecords;
        [Persistent]
        public int NoOfDebitRecords
        {
            get
            {
                return _noOfDebitRecords;
            }
            set
            {
                SetPropertyValue("NoOfDebitRecords", ref _noOfDebitRecords, value);
            }
        }
        private int _noOfCreditRecords;
        [Persistent]
        public int NoOfCreditRecords
        {
            get
            {
                return _noOfCreditRecords;
            }
            set
            {
                SetPropertyValue("NoOfCreditRecords", ref _noOfCreditRecords, value);
            }
        }
        private int _noOfContraRecords;
        [Persistent]
        public int NoOfContraRecords
        {
            get
            {
                return _noOfContraRecords;
            }
            set
            {
                SetPropertyValue("NoOfContraRecords", ref _noOfContraRecords, value);
            }
        }
        private decimal _totalDebit;
        [Persistent]
        public decimal TotalDebit
        {
            get
            {
                return _totalDebit;
            }
            set
            {
                SetPropertyValue("TotalDebit", ref _totalDebit, value);
            }
        }
        private decimal _totalCredit;
        [Persistent]
        public decimal TotalCredit
        {
            get
            {
                return _totalCredit;
            }
            set
            {
                SetPropertyValue("TotalCredit", ref _totalCredit, value);
            }
        }
        private string _HTHA150;
        [Persistent]
        public string HTHA150
        {
            get
            {
                return _HTHA150;
            }
            set
            {
                SetPropertyValue("HTHA150", ref _HTHA150, value);
            }
        }
        #region Constructors

        public ABSATrailer() : base() { }
        public ABSATrailer(Session session) : base(session) { }

        #endregion
    }
}
