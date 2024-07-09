using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public sealed class BOS_RoleMenuAccess : XPCustomObject
    {

        private Int64 _RoleMenuId;
        [Key(AutoGenerate = true)]
        public Int64 RoleMenuId
        {
            get
            {
                return _RoleMenuId;
            }
            set
            {
                SetPropertyValue("RoleMenuId", ref _RoleMenuId, value);
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

        private BOS_Menus _menu;
        [Persistent("MenuId")]
        public BOS_Menus Menu
        {
            get
            {
                return _menu;
            }
            set
            {
                SetPropertyValue("MenuId", ref _menu, value);
            }
        }

        #region Constructors

        public BOS_RoleMenuAccess() : base() { }
        public BOS_RoleMenuAccess(Session session) : base(session) { }

        #endregion
    }
}
