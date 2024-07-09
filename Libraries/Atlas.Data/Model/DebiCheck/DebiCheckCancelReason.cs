using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.DebiCheck
{
    public sealed class DebiCheckCancelReason : XPLiteObject
    {
        [Key]
        [Persistent]
        public long CancelReasonId { get; set; }

        [Persistent]
        public string Code { get; set; }

        [Persistent]
        public string Description { get; set; }

        [Persistent]
        public string CancellationCodeType { get; set; }

        public DebiCheckCancelReason() : base() { }
        public DebiCheckCancelReason(Session session) : base(session) { }
    }
}
