using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public sealed class BOS_RoleApiAccess : XPCustomObject
    {

        private Int64 _RoleApiAccessId;
        [Key(AutoGenerate = true)]
        public Int64 RoleApiAccessId
        {
            get
            {
                return _RoleApiAccessId;
            }
            set
            {
                SetPropertyValue("RoleApiAccessId", ref _RoleApiAccessId, value);
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

        private BOS_Object _object;
        [Persistent("ObjectId")]
        public BOS_Object Object
        {
            get
            {
                return _object;
            }
            set
            {
                SetPropertyValue("ObjectId", ref _object, value);
            }
        }

        private BOS_Action _action;
        [Persistent("ActionId")]
        public BOS_Action Action
        {
            get
            {
                return _action;
            }
            set
            {
                SetPropertyValue("ActionId", ref _action, value);
            }
        }


        #region Constructors

        public BOS_RoleApiAccess() : base() { }
        public BOS_RoleApiAccess(Session session) : base(session) { }

        #endregion
    }
}
