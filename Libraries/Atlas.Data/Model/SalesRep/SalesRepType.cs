using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.SalesRep
{
    public sealed class SalesRepType : XPLiteObject
    {
       
        [Key]
        [Persistent("SalesRepCode")]
        public char Type { get; set; }

        [Persistent]
        public string SalesRepDesc { get; set; }

        #region Constructors

        public SalesRepType() : base() { }
        public SalesRepType(Session session) : base(session) { }

        #endregion
    }
}
