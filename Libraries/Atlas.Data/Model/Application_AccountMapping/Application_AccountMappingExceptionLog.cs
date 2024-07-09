using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Application_AccountMapping
{
    public sealed class Application_AccountMappingExceptionLog : XPLiteObject
    {
        private long _exceptionLogId { get; set; }
        [Key(AutoGenerate = true)]
        public long ExceptionLogId
        {
            get
            {
                return _exceptionLogId;
            }
            set
            {
                _exceptionLogId = value;
            }
        }

        private long _applicationId { get; set; }
        public long ApplicationId
        {
            get
            {
                return _applicationId;
            }
            set
            {
                _applicationId = value;
            }
        }

        private long _accountId { get; set; }
        public long AccountId
        {
            get
            {
                return _accountId;
            }
            set
            {
                _accountId = value;
            }
        }

        private int _accountTypeId { get; set; }
        public int AccountTypeId
        {
            get
            {
                return _accountTypeId;
            }
            set
            {
                _accountTypeId = value;
            }
        }

        private string _errorLog { get; set; }
        public string ErrorLog
        {
            get
            {
                return _errorLog;
            }
            set
            {
                _errorLog = value;
            }
        }

        private string _action { get; set; }
        public string Action
        {
            get
            {
                return _action;
            }
            set
            {
                _action = value;
            }
        }

        private long _createdBy { get; set; }
        public long CreatedBy
        {
            get
            {
                return _createdBy;
            }
            set
            {
                _createdBy = value;
            }
        }

        private DateTime? _createdDate { get; set; }
        public DateTime? CreatedDate
        {
            get
            {
                return _createdDate;
            }
            set
            {
                _createdDate = value;
            }
        }

        private string _dbDetails { get; set; }
        public string DBDetails
        {
            get
            {
                return _dbDetails;
            }
            set
            {
                _dbDetails = value;
            }
        }

        #region Constructors

        public Application_AccountMappingExceptionLog() : base() { }
        public Application_AccountMappingExceptionLog(Session session) : base(session) { }

        #endregion
    }
}
