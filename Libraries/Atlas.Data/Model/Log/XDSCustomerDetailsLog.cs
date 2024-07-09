using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.Log
{
    public class XDSCustomerDetailsLog : XPLiteObject
    {
        private Int64 _XDSCustomerDetailsLogId;
        [Key(AutoGenerate = true)]
        public Int64 XDSCustomerDetailsLogId
        {
            get
            {
                return _XDSCustomerDetailsLogId;
            }
            set
            {
                SetPropertyValue("XDSCustomerDetailsLogId", ref _XDSCustomerDetailsLogId, value);
            }
        }

        private String _IdNumber;
        [Persistent]
        public String IdNumber
        {
            get
            {
                return _IdNumber;
            }
            set
            {
                SetPropertyValue("IdNumber", ref _IdNumber, value);
            }
        }

        private String _ApplicationId;
        [Persistent]
        public String ApplicationId
        {
            get
            {
                return _ApplicationId;
            }
            set
            {
                SetPropertyValue("ApplicationId", ref _ApplicationId, value);
            }
        }

        private String _Request;
        [Persistent]
        public String Request
        {
            get
            {
                return _Request;
            }
            set
            {
                SetPropertyValue("Request", ref _Request, value);
            }
        }

        private String _Response;
        [Persistent]
        public String Response
        {
            get
            {
                return _Response;
            }
            set
            {
                SetPropertyValue("Response", ref _Response, value);
            }
        }

        private String _Type;
        [Persistent]
        public String Type
        {
            get
            {
                return _Type;
            }
            set
            {
                SetPropertyValue("Type", ref _Type, value);
            }
        }

        private String _Status;
        [Persistent]
        public String Status
        {
            get
            {
                return _Status;
            }
            set
            {
                SetPropertyValue("Status", ref _Status, value);
            }
        }

        private String _CurrentCollection;
        [Persistent]
        public String CurrentCollection
        {
            get
            {
                return _CurrentCollection;
            }
            set
            {
                SetPropertyValue("CurrentCollection", ref _CurrentCollection, value);
            }
        }

        private String _UpdatedResponse;
        [Persistent]
        public String UpdatedResponse
        {
            get
            {
                return _UpdatedResponse;
            }
            set
            {
                SetPropertyValue("UpdatedResponse", ref _UpdatedResponse, value);
            }
        }

        public XDSCustomerDetailsLog() : base() { }
        public XDSCustomerDetailsLog(Session session) : base(session) { }
    }
}
