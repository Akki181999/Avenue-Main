using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace Atlas.Domain.Model.Branch
{
    public class QuoteApprovalTo : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public Int64 QuoteApprovalRequiredToId { get; set; }

        [Persistent]
        public string QuoteApprovalRequiredTo { get; set; }

        [Persistent]
        public Boolean IsActive { get; set; }

        #region Constructors

        public QuoteApprovalTo() : base() { }
        public QuoteApprovalTo(Session session) : base(session) { }

        #endregion
    }
}
