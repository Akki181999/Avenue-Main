using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avenue.Model.Avenue
{
    public sealed class BOS_Object : XPCustomObject
    {

        private Int64 _ObjectId;
        [Key(AutoGenerate = true)]
        public Int64 ObjectId
        {
            get
            {
                return _ObjectId;
            }
            set
            {
                SetPropertyValue("ObjectId", ref _ObjectId, value);
            }
        }

        private String _ObjectName;
        public string ObjectName
        {
            get
            {
                return _ObjectName;
            }
            set
            {
                SetPropertyValue("ObjectName", ref _ObjectName, value);
            }
        }

        #region Constructors

        public BOS_Object() : base() { }
        public BOS_Object(Session session) : base(session) { }

        #endregion
    }
}