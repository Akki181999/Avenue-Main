using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model
{

    public sealed class BOS_CollectionType : XPCustomObject
    {

        private Int64 _CollectionTypeId;
        [Key(AutoGenerate = false)]
        public Int64 CollectionTypeId
        {
            get
            {
                return _CollectionTypeId;
            }
            set
            {
                SetPropertyValue("CollectionTypeId", ref _CollectionTypeId, value);
            }
        }

        private string _CollectionTypeName;
        public string CollectionTypeName
        {
            get
            {
                return _CollectionTypeName;
            }
            set
            {
                SetPropertyValue("CollectionTypeName", ref _CollectionTypeName, value);
            }
        }

        #region Constructors

        public BOS_CollectionType() : base() { }
        public BOS_CollectionType(Session session) : base(session) { }

        #endregion
    }
}
