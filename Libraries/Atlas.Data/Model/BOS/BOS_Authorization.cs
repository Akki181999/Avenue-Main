using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public sealed class BOS_Authorization : XPLiteObject
    {

        private Int64 _AuthorizationId;
        [Key(AutoGenerate = true)]
        public Int64 AuthorizationId
        {
            get
            {
                return _AuthorizationId;
            }
            set
            {
                SetPropertyValue("AuthorizationId", ref _AuthorizationId, value);
            }
        }

        private String _Application;
        public string Application
        {
            get
            {
                return _Application;
            }
            set
            {
                SetPropertyValue("Application", ref _Application, value);
            }
        }

        private Auth_User _User;
        [Persistent("UserId")]
        public Auth_User User
        {
            get
            {
                return _User;
            }
            set
            {
                SetPropertyValue("User", ref _User, value);
            }
        }


        private BOS_Role _role;
        [Persistent("RoleId")]
        public BOS_Role Role
        {
            get
            {
                return _role;
            }
            set
            {
                SetPropertyValue("RoleId", ref _role, value);
            }
        }

        private BRN_Branch _Branch;
        [Persistent("BranchId")]
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

        private bool _IsDefault;
        public bool IsDefault
        {
            get
            {
                return _IsDefault;
            }
            set
            {
                SetPropertyValue("IsDefault", ref _IsDefault, value);
            }
        }

        private bool _CanSelfApprove;
        public bool CanSelfApprove
        {
            get
            {
                return _CanSelfApprove;
            }
            set
            {
                SetPropertyValue("CanSelfApprove", ref _CanSelfApprove, value);
            }
        }


        private DateTime? _FromDT;
        public DateTime? FromDT
        {
            get
            {
                return _FromDT;
            }
            set
            {
                SetPropertyValue("FromDT", ref _FromDT, value);
            }
        }

        private DateTime? _ToDT;
        public DateTime? ToDT
        {
            get
            {
                return _ToDT;
            }
            set
            {
                SetPropertyValue("ToDT", ref _ToDT, value);
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

        #region Constructors

        public BOS_Authorization() : base() { }
        public BOS_Authorization(Session session) : base(session) { }

        #endregion
    }
}
