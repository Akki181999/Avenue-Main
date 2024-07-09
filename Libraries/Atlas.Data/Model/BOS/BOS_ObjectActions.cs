using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{
    public sealed class BOS_ObjectActions : XPCustomObject
    {

        private Int64 _ObjectActionsId;
        [Key(AutoGenerate = true)]
        public Int64 ObjectActionsId
        {
            get
            {
                return _ObjectActionsId;
            }
            set
            {
                SetPropertyValue("ObjectActionsId", ref _ObjectActionsId, value);
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

        public BOS_ObjectActions() : base() { }
        public BOS_ObjectActions(Session session) : base(session) { }

        #endregion
    }
}
