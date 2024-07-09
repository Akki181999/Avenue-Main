using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Atlas.Domain.Model
{
    [Serializable]
    [DataContract]
    public class BOS_Session : XPCustomObject
    {
        private Int64 _SessionId;
        [Key(AutoGenerate = true)]
        [DataMember]
        public Int64 SessionId
        {
            get
            {
                return _SessionId;
            }
            set
            {
                SetPropertyValue("SessionId", ref _SessionId, value);
            }
        }

        private string _Token;
        [Persistent, Size(250)]
        [DataMember]
        public string Token
        {
            get
            {
                return _Token;
            }
            set
            {
                SetPropertyValue("Token", ref _Token, value);
            }
        }

        private DateTime _Expiry;
        [Persistent]
        [DataMember]
        public DateTime Expiry
        {
            get
            {
                return _Expiry;
            }
            set
            {
                SetPropertyValue("Expiry", ref _Expiry, value);
            }
        }

        private Auth_User _User;
        [Persistent("UserId")]
        [DataMember]
        public Auth_User User
        {
            get
            {
                return _User;
            }
            set
            {
                SetPropertyValue("UserId", ref _User, value);
            }
        }

        private bool _IsActive;
        [Persistent("IsActive")]
        [DataMember]
        public bool IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                SetPropertyValue("IsActive", ref _IsActive, value);
            }
        }

        private BOS_Role _Role;
        [Persistent("RoleId")]
        [DataMember]
        public BOS_Role Role
        {
            get
            {
                return _Role;
            }
            set
            {
                SetPropertyValue("RoleId", ref _Role, value);
            }
        }

        [DataMember]
        public DateTime LoginTime { get; set; }
        [DataMember]
        public DateTime? LogoutTime { get; set; }
        [DataMember]
        public string BrowserInfo { get; set; }
        [DataMember]
        public string MachineIp { get; set; }
        [DataMember]
        public string ScreenResolution { get; set; }
        [DataMember]
        public bool IsMannualLogout { get; set; }

        private BRN_Branch _Branch;
        [Persistent("BranchId")]
        [DataMember]
        public BRN_Branch Branch
        {
            get
            {
                return _Branch;
            }
            set
            {
                SetPropertyValue("Branch", ref _Branch, value);
            }
        }

        private string _AppId;
        [DataMember]
        public string AppId
        {
            get
            {
                return _AppId;
            }
            set
            {
                SetPropertyValue("AppId", ref _AppId, value);
            }
        }

        private Int64? _CompanyId;
        public Int64? CompanyId
        {
            get
            {
                return _CompanyId;
            }
            set
            {
                SetPropertyValue("CompanyId", ref _CompanyId, value);
            }
        }
    
        [Persistent]
        public bool isFingerPrintCheck { get; set; }
      
        [Persistent]
        public bool IsFingerPrintbypass { get; set; }
    
        [Persistent]
        public string ServerIpAddress { get; set; }

        #region Constructors

        public BOS_Session() : base() { }
        public BOS_Session(Session session) : base(session) { }

        #endregion
    }
}
