using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.BOS
{
   public sealed class BOS_AppObject : XPLiteObject
    {

        private Int64 _AppId;
       
        public Int64 AppId
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

        private String _AppCode;
        [Key]
        public string AppCode
        {
            get
            {
                return _AppCode;
            }
            set
            {
                SetPropertyValue("AppCode", ref _AppCode, value);
            }
        }

        private String _Description;
       
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                SetPropertyValue("Description", ref _Description, value);
            }
        }
        #region Constructors

        public BOS_AppObject() : base() { }
        public BOS_AppObject(Session session) : base(session) { }

        #endregion
    }
}
