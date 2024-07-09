using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.BOS
{
    public sealed class BOS_AppRoleMapping: XPLiteObject
    {

        private Int64 _MapId;
        [Key(AutoGenerate = true)]
        public Int64 MapId
        {
            get
            {
                return _MapId;
            }
            set
            {
                SetPropertyValue("MapId", ref _MapId, value);
            }
        }
        private BOS_Role _Role;
        [Persistent("RoleId")]
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

        private BOS_AppObject _AppObjects;
        [Persistent("AppCode")]
        public BOS_AppObject AppObjects
        {
            get
            {
                return _AppObjects;
            }
            set
            {
                SetPropertyValue("AppCode", ref _AppObjects, value);
            }
        }
        #region Constructors

        public BOS_AppRoleMapping() : base() { }
        public BOS_AppRoleMapping(Session session) : base(session) { }

        #endregion
    }
}
