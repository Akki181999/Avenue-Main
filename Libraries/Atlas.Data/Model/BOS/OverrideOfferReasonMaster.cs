using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.BOS
{
     public class OverrideOfferReasonMaster : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public int OverrideOfferReasonId { get; set; }
        [Persistent, Size(250)]
        public string OverrideOfferReason { get; set; }
        public bool IsActive { get; set; }

        public OverrideOfferReasonMaster() : base() { }
        public OverrideOfferReasonMaster(Session session) : base(session) { }
    }
}
