using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    [Serializable]
    [DataContract]
    public sealed class Auth_User : XPCustomObject
    {
        private Int64 _UserId;
        [Key(AutoGenerate = true)]
        [DataMember]
        public Int64 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                SetPropertyValue("UserId", ref _UserId, value);
            }
        }

        private String _UserName;
        [DataMember]
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                SetPropertyValue("UserName", ref _UserName, value);
            }
        }

        private String _Email;
        [DataMember]
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                SetPropertyValue("Email", ref _Email, value);
            }
        }

        private PER_Person _PersonId;
        [DataMember]
        public PER_Person PersonId
        {
            get
            {
                return _PersonId;
            }
            set
            {
                SetPropertyValue("PersonId", ref _PersonId, value);
            }
        }

        //private BRN_Branch _HomeBranch;
        //[DataMember]
        //public BRN_Branch HomeBranch
        //{
        //    get
        //    {
        //        return _HomeBranch;
        //    }
        //    set
        //    {
        //        SetPropertyValue("HomeBranch", ref _HomeBranch, value);
        //    }
        //}
        
        private bool _IsActive;
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

        #region Constructors

        public Auth_User() : base() { }
        public Auth_User(Session session) : base(session) { }

        #endregion
    }
}
