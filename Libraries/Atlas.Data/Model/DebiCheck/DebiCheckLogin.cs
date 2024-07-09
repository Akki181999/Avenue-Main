using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.DebiCheck
{
    public class DebiCheckLogin : XPLiteObject
    {
        public DebiCheckLogin() : base() { }
        public DebiCheckLogin(Session session) : base(session) { }

        private Int64 _DebiCheckLoginId;
        [Key(AutoGenerate = true)]
        public Int64 DebiCheckLoginId
        {
            get
            {
                return _DebiCheckLoginId;
            }
            set
            {
                SetPropertyValue("DebiCheckLoginId", ref _DebiCheckLoginId, value);
            }
        }

        private string _merchantId;
        [Persistent]
        public string MerchantId
        {
            get
            {
                return _merchantId;
            }
            set
            {
                SetPropertyValue("MerchantId", ref _merchantId, value);
            }
        }

        private string _username;
        [Persistent, Size(20)]
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                SetPropertyValue("Username", ref _username, value);
            }
        }

        private string _password;
        [Persistent, Size(20)]
        public string Password
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

        private DateTime _deletedDT;
        [Persistent]
        public DateTime DeletedDT
        {
            get
            {
                return _deletedDT;
            }
            set
            {
                SetPropertyValue("DeletedDT", ref _deletedDT, value);
            }
        }

        private int _credentialPurposeFlags;
        [Persistent]
        public int CredentialPurposeFlags
        {
            get
            {
                return _credentialPurposeFlags;
            }
            set
            {
                SetPropertyValue("CredentialPurposeFlags", ref _credentialPurposeFlags, value);
            }
        }

        private string _accessLevel;
        [Persistent]
        public string AccessLevel
        {
            get
            {
                return _accessLevel;
            }
            set
            {
                SetPropertyValue("AccessLevel", ref _accessLevel, value);
            }
        }
    }
}
