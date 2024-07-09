using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.PhoneType
{
    public sealed class PhoneType : XPLiteObject
    {

        [Key]
        [Persistent("PhoneTypeId")]
        public Int64 PhoneTypeId { get; set; }

        [Persistent]
        public string Description { get; set; }

        #region Constructors
        public PhoneType() : base() { }
        public PhoneType(Session session) : base(session) { }

        #endregion
    }
}