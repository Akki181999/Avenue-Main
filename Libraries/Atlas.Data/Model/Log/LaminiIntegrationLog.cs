using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Log
{
    //LamininApi
    public class LaminiIntegrationLog : XPLiteObject
    {
        private Int64 _laminiintegrationLogId;
        [Key(AutoGenerate = true)]
        public Int64 LaminiIntegrationLogId
        {
            get
            {
                return _laminiintegrationLogId;
            }
            set
            {
                SetPropertyValue("IntegrationLogId", ref _laminiintegrationLogId, value);
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
        public LaminiIntegrationLog() : base() { }
        public LaminiIntegrationLog(Session session) : base(session) { }
    }
}
