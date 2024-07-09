using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.Log
{
    public class ServiceProviderMaster : XPLiteObject
    {

        private Int64 _serviceProviderId;
        [Key(AutoGenerate = true)]
        public Int64 ServiceProviderId
        {
            get
            {
                return _serviceProviderId;
            }
            set
            {
                SetPropertyValue("ServiceProviderId", ref _serviceProviderId, value);
            }
        }

        private String _name;
        [Persistent]
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                SetPropertyValue("Name", ref _name, value);
            }
        }

        private String _url;
        [Persistent]
        public String Url
        {
            get
            {
                return _url;
            }
            set
            {
                SetPropertyValue("Url", ref _url, value);
            }
        }

        private String _userName;
        [Persistent]
        public String UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                SetPropertyValue("UserName", ref _userName, value);
            }
        }

        private String _password;
        [Persistent]
        public String Password
        {
            get
            {
                return _password;
            }
            set
            {
                SetPropertyValue("Password", ref _password, value);
            }
        }

        private String _account;
        [Persistent]
        public String Account
        {
            get
            {
                return _account;
            }
            set
            {
                SetPropertyValue("Account", ref _account, value);
            }
        }

        private Boolean _isActive;
        [Persistent]
        public Boolean IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                SetPropertyValue("IsActive", ref _isActive, value);
            }
        }

        public string ServiceType { get; set; }

        public string APIKey { get; set; }
        public string SecretKey1 { get; set; }
        public string SecretKey2 { get; set; }
        public string SecretKey3 { get; set; }
        public string ServerType { get; set; }
        public ServiceProviderMaster() : base() { }
        public ServiceProviderMaster(Session session) : base(session) { }
    }
}
