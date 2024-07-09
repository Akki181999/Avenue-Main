using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Atlas.Domain.Model.ABSA
{
    public class ABSAFileHeader : XPLiteObject
    {
        private int _ABSAFileHeaderId;
        [Persistent]
        [Key(AutoGenerate = true)]
        public int ABSAFileHeaderId
        {
            get
            {
                return _ABSAFileHeaderId;
            }
            set
            {
                SetPropertyValue("ABSAFileHeaderId", ref _ABSAFileHeaderId, value);
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
        private DateTime _bankservGlCreationDate;
        [Persistent]
        public DateTime BankservGlCreationDate
        {
            get
            {
                return _bankservGlCreationDate;
            }
            set
            {
                SetPropertyValue("BankservGlCreationDate", ref _bankservGlCreationDate, value);
            }
        }
        private DateTime _bankservPurgeDate;
        [Persistent]
        public DateTime BankservPurgeDate
        {
            get
            {
                return _bankservPurgeDate;
            }
            set
            {
                SetPropertyValue("BankservPurgeDate", ref _bankservPurgeDate, value);
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
        private int _userGenerationNumber;
        [Persistent]
        public int UserGenerationNumber
        {
            get
            {
                return _userGenerationNumber;
            }
            set
            {
                SetPropertyValue("UserGenerationNumber", ref _userGenerationNumber, value);
            }
        }
        private string _typeOfService;
        [Persistent]
        public string TypeOfService
        {
            get
            {
                return _typeOfService;
            }
            set
            {
                SetPropertyValue("TypeOfService", ref _typeOfService, value);
            }
        }
        private string _fileStatus;
        [Persistent]
        public string FileStatus
        {
            get
            {
                return _fileStatus;
            }
            set
            {
                SetPropertyValue("FileStatus", ref _fileStatus, value);
            }
        }

        private string _fileType;
        [Persistent]
        public string FileType
        {
            get
            {
                return _fileType;
            }
            set
            {
                SetPropertyValue("FileType", ref _fileType, value);
            }
        }

        #region Constructors

        public ABSAFileHeader() : base() { }
        public ABSAFileHeader(Session session) : base(session) { }

        #endregion
    }
}
