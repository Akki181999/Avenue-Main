using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Log
{
    public class IntegrationLog : XPLiteObject
    {
        private Int64 _integrationLogId;
        [Key(AutoGenerate = true)]
        public Int64 IntegrationLogId
        {
            get
            {
                return _integrationLogId;
            }
            set
            {
                SetPropertyValue("IntegrationLogId", ref _integrationLogId, value);
            }
        }
        private String _accountNo;
        [Persistent]
        public String AccountNo
        {
            get
            {
                return _accountNo;
            }
            set
            {
                SetPropertyValue("AccountNo", ref _accountNo, value);
            }
        }
        private String _applicationNo;
        [Persistent]
        public String ApplicationNo
        {
            get
            {
                return _applicationNo;
            }
            set
            {
                SetPropertyValue("ApplicationNo", ref _applicationNo, value);
            }
        }
        private string _clientID;
        [Persistent]
        public string ClientID
        {
            get
            {
                return _clientID;
            }
            set
            {
                SetPropertyValue("ClientID", ref _clientID, value);
            }
        }
        private String _request;
        [Persistent]
        public String Request
        {
            get
            {
                return _request;
            }
            set
            {
                SetPropertyValue("Request", ref _request, value);
            }
        }
        private String _response;
        [Persistent]
        public String Response
        {
            get
            {
                return _response;
            }
            set
            {
                SetPropertyValue("Response", ref _response, value);
            }
        }
        private String _integrationType;
        [Persistent]
        public String IntegrationType
        {
            get
            {
                return _integrationType;
            }
            set
            {
                SetPropertyValue("IntegrationType", ref _integrationType, value);
            }
        }

        private String _branchName;
        [Persistent]
        public String BranchName
        {
            get
            {
                return _branchName;
            }
            set
            {
                SetPropertyValue("BranchName", ref _branchName, value);
            }
        }

        private String _branchId;
        [Persistent]
        public String BranchId
        {
            get
            {
                return _branchId;
            }
            set
            {
                SetPropertyValue("BranchId", ref _branchId, value);
            }
        }
        private String _consultantName;
        [Persistent]
        public String ConsultantName
        {
            get
            {
                return _consultantName;
            }
            set
            {
                SetPropertyValue("ConsultantName", ref _consultantName, value);
            }
        }
        private String _eventName;
        [Persistent]
        public String EventName
        {
            get
            {
                return _eventName;
            }
            set
            {
                SetPropertyValue("EventName", ref _eventName, value);
            }
        }
        private String _status;
        [Persistent]
        public String Status
        {
            get
            {
                return _status;
            }
            set
            {
                SetPropertyValue("Status", ref _status, value);
            }
        }

        private DateTime _requestTime;
        [Persistent]
        public DateTime RequestTime
        {
            get
            {
                return _requestTime;
            }
            set
            {
                SetPropertyValue("RequestTime", ref _requestTime, value);
            }
        }
        public IntegrationLog() : base() { }
        public IntegrationLog(Session session) : base(session) { }
    }
}
